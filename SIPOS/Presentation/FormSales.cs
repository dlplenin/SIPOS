using SIPOS.Entities;
using SIPOS.Entities.Sales;
using SIPOS.Persistence.Repository.Contracts;
using System.Data;
using System.Windows.Forms;

namespace SIPOS.Presentation
{
    public partial class FormSales : Form
    {
        private decimal TotalSales { get; set; }
        private readonly IRepositoryWrapper repositoryWrapper;

        public FormSales(IRepositoryWrapper repositoryWrapper)
        {
            InitializeComponent();
            this.repositoryWrapper = repositoryWrapper;
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.LblPricePurchase, "Precio de compra");
            toolTip.SetToolTip(this.TxtPricePurchase, "Precio de compra");

            toolTip.SetToolTip(this.BtnSaveSaleOrder, "Guardar venta");

            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = repositoryWrapper.ProductRepository
                .GetAll()
                .ToList();
            CbProducts.DataSource = products;
            CbProducts.DisplayMember = "FullDescription";
            CbProducts.ValueMember = "Id";

            var productsToDetail = repositoryWrapper.ProductRepository
                .GetAll()
                .ToList();
            ColSalesProduct.DataSource = productsToDetail;
            ColSalesProduct.DisplayMember = "FullDescription";
            ColSalesProduct.ValueMember = "Id";
        }

        private void CbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = CbProducts.SelectedItem as Product;
            TxtPriceSell.Text = selectedProduct.PriceToSell.ToString();
            TxtSuggestedPriceToSell.Text = selectedProduct.PriceSugestedToSell.ToString();
            TxtPricePurchase.Text = selectedProduct.PricePurchase.ToString();
            TxtStock.Text = selectedProduct.Stock.ToString();

            TxtQty.Focus();
            TxtQty.Text = "1";
            TxtQty.SelectAll();

            //TxtPricePurchase.Text = string.Empty;
        }

        private void TxtQty_Enter(object sender, EventArgs e)
        {
            TxtQty.SelectAll();
        }

        private void TxtPriceSell_Enter(object sender, EventArgs e)
        {
            TxtPriceSell.SelectAll();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (AnyMissingRequiredTextBox("requiredProd"))
                return;

            var selectedProduct = CbProducts.SelectedItem as Product;
            var investedMoney = TxtQty.DecimalValue * TxtPricePurchase.DecimalValue;
            var profitMoney = TxtQty.DecimalValue * TxtPriceSell.DecimalValue - investedMoney;
            var totalSaleDetail = TxtQty.DecimalValue * TxtPriceSell.DecimalValue;
            DgvSaleDetail.Rows.Add(selectedProduct.Id, TxtPricePurchase.Text, TxtSuggestedPriceToSell.Text, TxtPriceSell.Text, TxtQty.Text, totalSaleDetail, investedMoney, profitMoney);

            UpdateTotalInvoice();
        }

        private bool AnyMissingRequiredTextBox(string tag)
        {
            errorProvider.Clear();

            var requiredBoxes = Controls.OfType<TextBox>().Where(x => (x.Tag ?? "").ToString() == tag);

            var anyMissingRequired = false;
            foreach (var box in requiredBoxes)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    anyMissingRequired = true;
                    errorProvider.SetError(box, "Es un campo requerido");
                }
            }

            return anyMissingRequired;
        }

        private void UpdateTotalInvoice()
        {
            var totalSales = 0M;
            var totalInvested = 0M;
            var totalProfit = 0M;
            foreach (DataGridViewRow row in DgvSaleDetail.Rows)
            {
                totalSales += Convert.ToDecimal(row.Cells[ColSalesTotal.Name].Value);
                totalInvested += Convert.ToDecimal(row.Cells[ColSalesInvested.Name].Value);
                totalProfit += Convert.ToDecimal(row.Cells[ColSalesProfit.Name].Value);
            }

            LblTotalSales.Text = $"Venta: $ {totalSales:N2}";
            LblTotalInvested.Text = $"Inversion: $ {totalInvested:N2}";
            LblTotalProfit.Text = $"Ganancia: $ {totalProfit:N2}";

            TotalSales = totalSales;
        }

        private void BtnSaveSaleOrder_Click(object sender, EventArgs e)
        {
            try
            {
                repositoryWrapper.BeginTransaction();
                var order = new SaleOrder
                {
                    Invoice = TxtInvoice.Text,
                    InvoiceDate = DtpInvoice.Value,
                    Total = TotalSales
                };


            }
            catch (Exception)
            {

                throw;
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

        private void DgvSaleDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == this.ColSalesDelete.Index)
                {
                    var productCell = this.DgvSaleDetail.Rows[e.RowIndex].Cells[ColSalesProduct.Name];
                    var confirmResult = MessageBox.Show($"Está seguro de eliminar el registro: {productCell.FormattedValue}?",
                                     "Confirmación",
                                     MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        DgvSaleDetail.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void DgvSaleDetail_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DgvSaleDetail.Cursor = Cursors.Default;

            if (e.ColumnIndex == ColSalesDelete.Index)
            {
                DgvSaleDetail.Cursor = Cursors.Hand;
            }
        }
    }
}
