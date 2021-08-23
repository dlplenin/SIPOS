using SIPOS.Entities;
using SIPOS.Entities.Goods;
using SIPOS.Persistence.Repository.Contracts;
using System.Windows.Forms;

namespace SIPOS.Presentation.Goods
{
    public partial class FormGoodsOrder : Form
    {
        private decimal TotalInvested { get; set; }
        private readonly IRepositoryWrapper repositoryWrapper;

        public FormGoodsOrder(IRepositoryWrapper repositoryWrapper)
        {
            InitializeComponent();
            this.repositoryWrapper = repositoryWrapper;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormGoodsOrder_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.lblPricePurchase, "Precio de compra");
            toolTip.SetToolTip(this.TxtPricePurchase, "Precio de compra");

            toolTip.SetToolTip(this.LblCurrentPricePurchace, "Precio de compra actual");
            toolTip.SetToolTip(this.TxtCurrentPricePurchase, "Precio de compra actual");

            toolTip.SetToolTip(this.BtnSaveGoodsOrder, "Guardar factura");

            LoadSuppliersAndProducts();
        }

        private void LoadSuppliersAndProducts()
        {
            var suppliers = repositoryWrapper.SupplierRepository
                            .GetAll()
                            .ToList();

            CbSuppliers.DataSource = suppliers;
            CbSuppliers.DisplayMember = "Name";
            CbSuppliers.ValueMember = "Id";

            var products = repositoryWrapper.ProductRepository
                .GetAll()
                .ToList();
            CbProducts.DataSource = products;
            CbProducts.DisplayMember = "FullDescription";
            CbProducts.ValueMember = "Id";

            var productsToDetail = repositoryWrapper.ProductRepository
                .GetAll()
                .ToList();
            ColGoodsProduct.DataSource = productsToDetail;
            ColGoodsProduct.DisplayMember = "FullDescription";
            ColGoodsProduct.ValueMember = "Id";
        }

        private void CbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = CbProducts.SelectedItem as Product;
            TxtPriceSell.Text = selectedProduct.PriceToSell.ToString();
            TxtSuggestedPriceToSell.Text = selectedProduct.PriceSugestedToSell.ToString();
            TxtCurrentPricePurchase.Text = selectedProduct.PricePurchase.ToString();
            TxtStock.Text = selectedProduct.Stock.ToString();

            TxtQty.Focus();
            TxtQty.Text = "1";
            TxtQty.SelectAll();

            TxtPricePurchase.Text = string.Empty;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (AnyMissingRequiredTextBox("requiredProd"))
                return;

            var selectedProduct = CbProducts.SelectedItem as Product;
            var investedMoney = TxtQty.DecimalValue * TxtPricePurchase.DecimalValue;
            var profitMoney = TxtQty.DecimalValue * TxtPriceSell.DecimalValue - investedMoney;
            DgvGoods.Rows.Add("", selectedProduct.Id, TxtPricePurchase.Text, TxtSuggestedPriceToSell.Text, TxtPriceSell.Text, TxtQty.Text, investedMoney, profitMoney);

            UpdateTotalInvoice();
        }

        private bool AnyMissingRequiredTextBox(string tag)
        {
            errorProviderProd.Clear();

            var requiredBoxes = Controls.OfType<TextBox>().Where(x => (x.Tag ?? "").ToString() == tag);
            
            // find into group boxes
            foreach (var textBox in Controls.OfType<GroupBox>().SelectMany(groupBox => groupBox.Controls.OfType<TextBox>().Where(x => (x.Tag ?? "").ToString() == tag)))
            {
                requiredBoxes = requiredBoxes.Append(textBox);
            }

            var anyMissingRequired = false;
            foreach (var box in requiredBoxes)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    anyMissingRequired = true;
                    errorProviderProd.SetError(box, "Es un campo requerido");
                }
            }

            return anyMissingRequired;
        }

        private void UpdateTotalInvoice()
        {
            var totalInvested = 0M;
            var totalProfit = 0M;
            foreach (DataGridViewRow row in DgvGoods.Rows)
            {
                totalInvested += Convert.ToDecimal(row.Cells[ColGoodsInvested.Name].Value);
                totalProfit += Convert.ToDecimal(row.Cells[ColGoodsProfit.Name].Value);
            }

            LblTotalInvested.Text = $"Inversion: $ {totalInvested:N2}";
            LblTotalProfit.Text = $"Ganancia: $ {totalProfit:N2}";

            TotalInvested = totalInvested;
        }

        private void BtnSaveGoodsOrder_Click(object sender, EventArgs e)
        {
            if (AnyMissingRequiredTextBox("requiredGoodsOrder"))
                return;

            try
            {
                repositoryWrapper.BeginTransaction();

                var order = new GoodsOrder
                {
                    Invoice = TxtInvoice.Text,
                    InvoiceDate = DtpInvoice.Value,
                    Notes = TxtNotes.Text,
                    Total = TotalInvested,
                    SuplierId = new Guid(CbSuppliers.SelectedValue.ToString())
                };
                repositoryWrapper.GoodsOrderRepository.Create(order);

                foreach (DataGridViewRow row in DgvGoods.Rows)
                {
                    var productId = row.Cells[ColGoodsProduct.Name].Value.ToString();
                    var qty = Convert.ToDecimal(row.Cells[ColGoodsQty.Name].Value);
                    var priceToSell = Convert.ToDecimal(row.Cells[ColGoodsPVP.Name].Value);
                    var purchasePrice = Convert.ToDecimal(row.Cells[ColGoodsPricePurchase.Name].Value);
                    var suggestedPrice = Convert.ToDecimal(row.Cells[ColGoodsSuggestedPrice.Name].Value);
                    var totalInvested = Convert.ToDecimal(row.Cells[ColGoodsInvested.Name].Value);

                    var detail = new GoodsOrderDetail
                    {
                        GoodsOrderId = order.Id,
                        ProductId= new Guid(productId),
                        Quantity = qty,
                        PriceToSell = priceToSell,
                        PricePurchase = purchasePrice,
                        PriceSugestedToSell = suggestedPrice,
                        Total = totalInvested
                    };
                    repositoryWrapper.GoodsOrderDetailRepository.Create(detail);

                    // Update Product stock & prices
                    var productoToUpdate = repositoryWrapper.ProductRepository.GetById(new Guid(productId));
                    productoToUpdate.PricePurchase = purchasePrice;
                    productoToUpdate.PriceSugestedToSell = suggestedPrice;
                    productoToUpdate.PriceToSell = priceToSell;
                    productoToUpdate.Stock += qty;

                    repositoryWrapper.ProductRepository.Update(productoToUpdate);
                }

                ClearTextBox();
                LoadSuppliersAndProducts();
                DgvGoods.Rows.Clear();

                TotalInvested = 0;
                LblTotalInvested.Text = "$";
                LblTotalProfit.Text = "$";

                repositoryWrapper.CommitTransaction();

                MessageBox.Show("La orden se ingresó correctamente", "Mercadería");
            }
            catch(Exception ex)
            {
                repositoryWrapper.RollbackTransaction();
            }
        }

        private void ClearTextBox()
        {
            var boxesToClear = Controls.OfType<TextBox>();

            foreach (var textBox in Controls.OfType<GroupBox>().SelectMany(groupBox => groupBox.Controls.OfType<TextBox>()))
            {
                boxesToClear = boxesToClear.Append(textBox);
            }

            foreach (var box in boxesToClear)
            {
                box.Text = string.Empty;
            }
        }

        private void DgvGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == this.ColGoodsDelete.Index)
                {
                    var productCell = this.DgvGoods.Rows[e.RowIndex].Cells[ColGoodsProduct.Name];
                    var confirmResult = MessageBox.Show($"Está seguro de eliminar el registro: {productCell.FormattedValue}?",
                                     "Confirmación",
                                     MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        DgvGoods.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void DgvGoods_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DgvGoods.Cursor = Cursors.Default;

            if (e.ColumnIndex == ColGoodsDelete.Index)
            {
                DgvGoods.Cursor = Cursors.Hand;
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
