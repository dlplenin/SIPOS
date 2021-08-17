using SIPOS.Entities;
using SIPOS.Persistence.Repository;
using System.Windows.Forms;

namespace SIPOS.Presentation.Goods
{
    public partial class FormGoodsOrder : Form
    {
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


            ColGoodsProduct.DataSource = products;
            ColGoodsProduct.DisplayMember = "FullDescription";
            ColGoodsProduct.ValueMember = "Id";
        }

        private void CbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = CbProducts.SelectedItem as Product;
            TxtPriceSell.Text = selectedProduct.PriceSell.ToString();
            TxtSuggestedPriceToSell.Text = selectedProduct.SugestedPriceToSell.ToString();
            TxtCurrentPricePurchase.Text = selectedProduct.PricePurchase.ToString();
            TxtStock.Text = selectedProduct.Stock.ToString();

            TxtQty.Focus();
            TxtQty.Text = "1";
            TxtQty.SelectAll();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (AnyMissingRequiredProductTextBox())
                return;

            var selectedProduct = CbProducts.SelectedItem as Product;
            var investedMoney = TxtQty.DecimalValue * TxtPricePurchase.DecimalValue;
            var profitMoney = TxtQty.DecimalValue * TxtPriceSell.DecimalValue - investedMoney;
            DgvGoods.Rows.Add("", selectedProduct.Id, TxtPricePurchase.Text, TxtSuggestedPriceToSell.Text, TxtPriceSell.Text, TxtQty.Text, investedMoney, profitMoney);

            UpdateTotalInvoice();
        }

        private bool AnyMissingRequiredProductTextBox()
        {
            errorProviderProd.Clear();
            var requiredBoxes = Controls.OfType<TextBox>().Where(x => (x.Tag ?? "").ToString() == "requiredProd");
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
        }
    }
}
