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
                //.Select(s => new { s.Id, Name = $"{s.Name} || {s.Description}", s.SugestedPriceToSell, s.PriceSell })
                .ToList();
            CbProducts.DataSource = products;
            CbProducts.DisplayMember = "FullDescription";
            CbProducts.ValueMember = "Id";
        }

        private void CbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = CbProducts.SelectedItem as Product;
            TxtPriceSell.Text = selectedProduct.PriceSell.ToString();
            TxtSugestedPriceToSell.Text = selectedProduct.SugestedPriceToSell.ToString();
            TxtCurrentPricePurchase.Text = selectedProduct.PricePurchase.ToString();
            TxtStock.Text = selectedProduct.Stock.ToString();
        }
    }
}
