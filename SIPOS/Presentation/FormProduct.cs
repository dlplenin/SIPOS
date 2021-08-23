using SIPOS.Entities;
using SIPOS.Persistence.Repository.Contracts;
using System.Data;
using System.Windows.Forms;

namespace SIPOS.Presentation
{
    public partial class FormProduct : Form
    {
        private readonly IRepositoryWrapper repositoryWrapper;

        public FormProduct(IRepositoryWrapper repositoryWrapper)
        {
            InitializeComponent();
            this.repositoryWrapper = repositoryWrapper;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            DgvProducts.Rows.Clear();

            var productsInDBTemp = repositoryWrapper.ProductRepository;
            List<Product> productsInDB;
            if (string.IsNullOrWhiteSpace(TxtFilterName.Text))
            {
                productsInDB = productsInDBTemp
                    .GetAll()
                    .ToList();
            }
            else
            {
                productsInDB = productsInDBTemp
                    .FindByCondition(x => x.Name.Contains(TxtFilterName.Text))
                    .ToList();
            }

            foreach (var item in productsInDB)
            {
                var investedMoney = item.Stock * item.PricePurchase;
                var profitMoney = item.Stock * item.PriceToSell - investedMoney;
                DgvProducts.Rows.Add(item.Id, item.Name, item.Description, item.PricePurchase, item.PriceSugestedToSell, item.PriceToSell, item.Stock, investedMoney.ToString("N2"), profitMoney.ToString("N2"), item.Activo);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (AnyMissingRequiredTextBox())
                return;

            var newProduct = new Product
            {
                Name = TxtName.Text,
                Description = TxtDescription.Text,
                PricePurchase = TxtPricePurchase.DecimalValue,
                PriceSugestedToSell = TxtSugestedPriceToSell.DecimalValue,
                PriceToSell = Convert.ToDecimal(TxtPriceSell.TextOrDefault),
                Stock = Convert.ToDecimal(TxtStock.TextOrDefault),
            };
            repositoryWrapper.ProductRepository.Create(newProduct);
            repositoryWrapper.Save();

            ClearTextBox();

            LoadProducts();
        }

        private void ClearTextBox()
        {
            var boxesToClear = Controls.OfType<TextBox>();
            foreach (var box in boxesToClear)
            {
                box.Text = string.Empty;
            }
        }

        private bool AnyMissingRequiredTextBox()
        {
            errorProvider.Clear();
            var requiredBoxes = Controls.OfType<TextBox>().Where(x => (x.Tag ?? "").ToString() == "required");
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

        private void DgvProduct_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DgvProducts.Cursor = Cursors.Default;
            if (e.ColumnIndex == ColProductUpdate.Index)
                DgvProducts.Cursor = Cursors.Hand;
        }

        private void DgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == this.ColProductUpdate.Index)
                {
                    var userRow = this.DgvProducts.Rows[e.RowIndex].Cells;

                    var userId = userRow[ColProductId.Name].Value.ToString();
                    var name = userRow[ColProductName.Name].Value.ToString();
                    var description = userRow[ColProductDescription.Name].Value.ToString();
                    var pricePurchase = userRow[ColProductPricePurchase.Name].Value.ToString();
                    var suggestedPrice = userRow[ColProductSuggestedPrice.Name].Value.ToString();
                    var priceSell = userRow[ColProductPVP.Name].Value.ToString();
                    var stock = userRow[ColProductStock.Name].Value.ToString();
                    var active = (bool)userRow[ColproductActive.Name].Value;

                    var productToUpdate = repositoryWrapper.ProductRepository.GetById(new Guid(userId));
                    productToUpdate.Name = name;
                    productToUpdate.Description = description;
                    productToUpdate.PricePurchase = Convert.ToDecimal(pricePurchase);
                    productToUpdate.PriceSugestedToSell = Convert.ToDecimal(suggestedPrice);
                    productToUpdate.PriceToSell = Convert.ToDecimal(priceSell);
                    productToUpdate.Stock = Convert.ToDecimal(stock);
                    productToUpdate.Activo = active;

                    repositoryWrapper.ProductRepository.Update(productToUpdate);
                    repositoryWrapper.Save();
                }
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        //private void TxtName_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(TxtName.Text))
        //    {
        //        TxtName.Focus();
        //        errorProvider.SetError(TxtName, "Es requerido");
        //    }
        //    else
        //    {
        //        errorProvider.Clear();
        //    }
        //}
    }
}
