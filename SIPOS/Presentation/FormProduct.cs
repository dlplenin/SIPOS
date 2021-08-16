using SIPOS.Entities;
using SIPOS.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            var productsInDB = repositoryWrapper.ProductRepository.GetAll().ToList();

            foreach (var item in productsInDB)
            {
                DgvProducts.Rows.Add(item.Id, item.Name, item.Description, item.PricePurchase, item.SugestedPriceToSell, item.PriceSell, item.Activo);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var newProduct = new Product
            {
                Name = TxtName.Text,
                Description = TxtDescription.Text,
                PricePurchase =  Convert.ToDecimal(TxtPricePurchase.Text),
                //SugestedPriceToSell = Convert.ToDecimal(TxtSugestedPriceToSell.Text),
                //PriceSell = Convert.ToDecimal(TxtPriceSell)
            };
            repositoryWrapper.ProductRepository.Create(newProduct);
            repositoryWrapper.Save();

            LoadProducts();
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
                    var active = (bool)userRow[ColproductActive.Name].Value;

                    var productToUpdate = repositoryWrapper.ProductRepository.GetById(new Guid(userId));
                    productToUpdate.Name = name;
                    productToUpdate.Description = description;
                    productToUpdate.PricePurchase = Convert.ToDecimal(pricePurchase);
                    productToUpdate.SugestedPriceToSell = Convert.ToDecimal(suggestedPrice);
                    productToUpdate.PriceSell = Convert.ToDecimal(priceSell);
                    productToUpdate.Activo = active;

                    repositoryWrapper.ProductRepository.Update(productToUpdate);
                    repositoryWrapper.Save();
                }
            }
        }
    }
}
