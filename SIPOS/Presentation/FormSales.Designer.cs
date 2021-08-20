
namespace SIPOS.Presentation
{
    partial class FormSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSales));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblTotalProfit = new System.Windows.Forms.Label();
            this.LblTotalInvested = new System.Windows.Forms.Label();
            this.DtpInvoice = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtInvoice = new System.Windows.Forms.TextBox();
            this.BtnSaveSaleOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TxtStock = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbProducts = new System.Windows.Forms.ComboBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtQty = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPriceSell = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.TxtSuggestedPriceToSell = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.TxtPricePurchase = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.lblPricePurchase = new System.Windows.Forms.Label();
            this.TxtFilterName = new System.Windows.Forms.TextBox();
            this.DgvSaleDetail = new System.Windows.Forms.DataGridView();
            this.ColGoodsDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoodsProduct = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColGoodsPricePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoodsSuggestedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoodsPVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoodsQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoodsProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoodsDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTotalSale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaleDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 200;
            this.errorProvider.ContainerControl = this;
            // 
            // LblTotalProfit
            // 
            this.LblTotalProfit.AutoSize = true;
            this.LblTotalProfit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotalProfit.ForeColor = System.Drawing.Color.LimeGreen;
            this.LblTotalProfit.Location = new System.Drawing.Point(838, 134);
            this.LblTotalProfit.Name = "LblTotalProfit";
            this.LblTotalProfit.Size = new System.Drawing.Size(28, 35);
            this.LblTotalProfit.TabIndex = 62;
            this.LblTotalProfit.Text = "$";
            // 
            // LblTotalInvested
            // 
            this.LblTotalInvested.AutoSize = true;
            this.LblTotalInvested.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotalInvested.ForeColor = System.Drawing.Color.IndianRed;
            this.LblTotalInvested.Location = new System.Drawing.Point(838, 99);
            this.LblTotalInvested.Name = "LblTotalInvested";
            this.LblTotalInvested.Size = new System.Drawing.Size(28, 35);
            this.LblTotalInvested.TabIndex = 61;
            this.LblTotalInvested.Text = "$";
            // 
            // DtpInvoice
            // 
            this.DtpInvoice.CustomFormat = "dd \'de\'MMMM\'de\' yyyy";
            this.DtpInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpInvoice.Location = new System.Drawing.Point(484, 74);
            this.DtpInvoice.Name = "DtpInvoice";
            this.DtpInvoice.Size = new System.Drawing.Size(212, 27);
            this.DtpInvoice.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "Fecha factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Factura";
            // 
            // TxtInvoice
            // 
            this.TxtInvoice.Location = new System.Drawing.Point(101, 74);
            this.TxtInvoice.Name = "TxtInvoice";
            this.TxtInvoice.Size = new System.Drawing.Size(248, 27);
            this.TxtInvoice.TabIndex = 2;
            this.TxtInvoice.Tag = "requiredGoodsOrder";
            // 
            // BtnSaveSaleOrder
            // 
            this.BtnSaveSaleOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveSaleOrder.Image = global::SIPOS.Properties.Resources.add_file_100;
            this.BtnSaveSaleOrder.Location = new System.Drawing.Point(926, 209);
            this.BtnSaveSaleOrder.Name = "BtnSaveSaleOrder";
            this.BtnSaveSaleOrder.Size = new System.Drawing.Size(97, 100);
            this.BtnSaveSaleOrder.TabIndex = 74;
            this.BtnSaveSaleOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "PVP";
            // 
            // TxtStock
            // 
            this.TxtStock.DecimalPlaces = 4;
            this.TxtStock.Location = new System.Drawing.Point(702, 108);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.ReadOnly = true;
            this.TxtStock.Size = new System.Drawing.Size(100, 27);
            this.TxtStock.TabIndex = 88;
            this.TxtStock.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(651, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 89;
            this.label5.Text = "Stock";
            // 
            // CbProducts
            // 
            this.CbProducts.FormattingEnabled = true;
            this.CbProducts.Location = new System.Drawing.Point(101, 107);
            this.CbProducts.Name = "CbProducts";
            this.CbProducts.Size = new System.Drawing.Size(535, 28);
            this.CbProducts.TabIndex = 68;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkRate = 200;
            this.errorProvider2.ContainerControl = this;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackgroundImage = global::SIPOS.Properties.Resources.filter_16px;
            this.BtnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Location = new System.Drawing.Point(217, 282);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(44, 27);
            this.BtnFiltrar.TabIndex = 77;
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 83;
            this.label6.Text = "Cantidad";
            // 
            // TxtQty
            // 
            this.TxtQty.DecimalPlaces = 4;
            this.TxtQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtQty.Location = new System.Drawing.Point(101, 142);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(76, 34);
            this.TxtQty.TabIndex = 69;
            this.TxtQty.Tag = "requiredProd";
            this.TxtQty.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "PVP sugerido";
            // 
            // TxtPriceSell
            // 
            this.TxtPriceSell.DecimalPlaces = 4;
            this.TxtPriceSell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPriceSell.Location = new System.Drawing.Point(738, 142);
            this.TxtPriceSell.Name = "TxtPriceSell";
            this.TxtPriceSell.Size = new System.Drawing.Size(65, 34);
            this.TxtPriceSell.TabIndex = 72;
            this.TxtPriceSell.Tag = "requiredProd";
            // 
            // TxtSuggestedPriceToSell
            // 
            this.TxtSuggestedPriceToSell.DecimalPlaces = 4;
            this.TxtSuggestedPriceToSell.Location = new System.Drawing.Point(588, 142);
            this.TxtSuggestedPriceToSell.Name = "TxtSuggestedPriceToSell";
            this.TxtSuggestedPriceToSell.ReadOnly = true;
            this.TxtSuggestedPriceToSell.Size = new System.Drawing.Size(65, 27);
            this.TxtSuggestedPriceToSell.TabIndex = 71;
            // 
            // TxtPricePurchase
            // 
            this.TxtPricePurchase.DecimalPlaces = 4;
            this.TxtPricePurchase.Location = new System.Drawing.Point(385, 142);
            this.TxtPricePurchase.Name = "TxtPricePurchase";
            this.TxtPricePurchase.ReadOnly = true;
            this.TxtPricePurchase.Size = new System.Drawing.Size(65, 27);
            this.TxtPricePurchase.TabIndex = 70;
            this.TxtPricePurchase.Tag = "requiredProd";
            // 
            // lblPricePurchase
            // 
            this.lblPricePurchase.AutoSize = true;
            this.lblPricePurchase.Location = new System.Drawing.Point(353, 145);
            this.lblPricePurchase.Name = "lblPricePurchase";
            this.lblPricePurchase.Size = new System.Drawing.Size(26, 20);
            this.lblPricePurchase.TabIndex = 82;
            this.lblPricePurchase.Text = "PC";
            // 
            // TxtFilterName
            // 
            this.TxtFilterName.Location = new System.Drawing.Point(18, 282);
            this.TxtFilterName.Name = "TxtFilterName";
            this.TxtFilterName.Size = new System.Drawing.Size(193, 27);
            this.TxtFilterName.TabIndex = 76;
            this.TxtFilterName.Tag = "required";
            // 
            // DgvSaleDetail
            // 
            this.DgvSaleDetail.AllowUserToAddRows = false;
            this.DgvSaleDetail.AllowUserToDeleteRows = false;
            this.DgvSaleDetail.AllowUserToOrderColumns = true;
            this.DgvSaleDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSaleDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSaleDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColGoodsDetailId,
            this.ColGoodsProduct,
            this.ColGoodsPricePurchase,
            this.ColGoodsSuggestedPrice,
            this.ColGoodsPVP,
            this.ColGoodsQty,
            this.ColGoodsProfit,
            this.ColGoodsDelete});
            this.DgvSaleDetail.Location = new System.Drawing.Point(12, 315);
            this.DgvSaleDetail.Name = "DgvSaleDetail";
            this.DgvSaleDetail.ReadOnly = true;
            this.DgvSaleDetail.RowHeadersWidth = 49;
            this.DgvSaleDetail.RowTemplate.Height = 28;
            this.DgvSaleDetail.ShowCellToolTips = false;
            this.DgvSaleDetail.Size = new System.Drawing.Size(1011, 421);
            this.DgvSaleDetail.TabIndex = 75;
            // 
            // ColGoodsDetailId
            // 
            this.ColGoodsDetailId.HeaderText = "GoodsDetailId";
            this.ColGoodsDetailId.MinimumWidth = 6;
            this.ColGoodsDetailId.Name = "ColGoodsDetailId";
            this.ColGoodsDetailId.ReadOnly = true;
            this.ColGoodsDetailId.Visible = false;
            this.ColGoodsDetailId.Width = 120;
            // 
            // ColGoodsProduct
            // 
            this.ColGoodsProduct.HeaderText = "Producto";
            this.ColGoodsProduct.MinimumWidth = 6;
            this.ColGoodsProduct.Name = "ColGoodsProduct";
            this.ColGoodsProduct.ReadOnly = true;
            this.ColGoodsProduct.Width = 120;
            // 
            // ColGoodsPricePurchase
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsPricePurchase.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColGoodsPricePurchase.HeaderText = "Precio compra";
            this.ColGoodsPricePurchase.MinimumWidth = 6;
            this.ColGoodsPricePurchase.Name = "ColGoodsPricePurchase";
            this.ColGoodsPricePurchase.ReadOnly = true;
            this.ColGoodsPricePurchase.Width = 120;
            // 
            // ColGoodsSuggestedPrice
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsSuggestedPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColGoodsSuggestedPrice.HeaderText = "PVP sugerido";
            this.ColGoodsSuggestedPrice.MinimumWidth = 6;
            this.ColGoodsSuggestedPrice.Name = "ColGoodsSuggestedPrice";
            this.ColGoodsSuggestedPrice.ReadOnly = true;
            this.ColGoodsSuggestedPrice.Width = 120;
            // 
            // ColGoodsPVP
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsPVP.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColGoodsPVP.HeaderText = "PVP";
            this.ColGoodsPVP.MinimumWidth = 6;
            this.ColGoodsPVP.Name = "ColGoodsPVP";
            this.ColGoodsPVP.ReadOnly = true;
            this.ColGoodsPVP.Width = 120;
            // 
            // ColGoodsQty
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsQty.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColGoodsQty.HeaderText = "Cantidad";
            this.ColGoodsQty.MinimumWidth = 6;
            this.ColGoodsQty.Name = "ColGoodsQty";
            this.ColGoodsQty.ReadOnly = true;
            this.ColGoodsQty.Width = 120;
            // 
            // ColGoodsProfit
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsProfit.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColGoodsProfit.HeaderText = "Total PVP";
            this.ColGoodsProfit.MinimumWidth = 6;
            this.ColGoodsProfit.Name = "ColGoodsProfit";
            this.ColGoodsProfit.ReadOnly = true;
            this.ColGoodsProfit.Width = 120;
            // 
            // ColGoodsDelete
            // 
            this.ColGoodsDelete.HeaderText = "";
            this.ColGoodsDelete.Image = global::SIPOS.Properties.Resources.eraser_16px;
            this.ColGoodsDelete.MinimumWidth = 6;
            this.ColGoodsDelete.Name = "ColGoodsDelete";
            this.ColGoodsDelete.ReadOnly = true;
            this.ColGoodsDelete.Width = 60;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.LblTitle.Location = new System.Drawing.Point(390, 15);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(274, 35);
            this.LblTitle.TabIndex = 79;
            this.LblTitle.Text = "REGISTRO DE VENTAS";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(993, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 29);
            this.BtnCerrar.TabIndex = 78;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Image = global::SIPOS.Properties.Resources.add_64px;
            this.BtnAgregar.Location = new System.Drawing.Point(101, 182);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(69, 67);
            this.BtnAgregar.TabIndex = 73;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 81;
            this.label4.Text = "Producto";
            // 
            // LblTotalSale
            // 
            this.LblTotalSale.AutoSize = true;
            this.LblTotalSale.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotalSale.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblTotalSale.Location = new System.Drawing.Point(838, 64);
            this.LblTotalSale.Name = "LblTotalSale";
            this.LblTotalSale.Size = new System.Drawing.Size(28, 35);
            this.LblTotalSale.TabIndex = 90;
            this.LblTotalSale.Text = "$";
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 748);
            this.Controls.Add(this.LblTotalSale);
            this.Controls.Add(this.LblTotalProfit);
            this.Controls.Add(this.LblTotalInvested);
            this.Controls.Add(this.BtnSaveSaleOrder);
            this.Controls.Add(this.DtpInvoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtInvoice);
            this.Controls.Add(this.CbProducts);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPriceSell);
            this.Controls.Add(this.TxtSuggestedPriceToSell);
            this.Controls.Add(this.TxtPricePurchase);
            this.Controls.Add(this.lblPricePurchase);
            this.Controls.Add(this.TxtFilterName);
            this.Controls.Add(this.DgvSaleDetail);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label4);
            this.Name = "FormSales";
            this.Text = "FormSales";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaleDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label LblTotalProfit;
        private System.Windows.Forms.Label LblTotalInvested;
        private System.Windows.Forms.DateTimePicker DtpInvoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtInvoice;
        private System.Windows.Forms.Button BtnSaveSaleOrder;
        private System.Windows.Forms.Label label1;
        private UserControls.DecimalTextBox TxtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbProducts;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label label6;
        private UserControls.DecimalTextBox TxtQty;
        private System.Windows.Forms.Label label3;
        private UserControls.DecimalTextBox TxtPriceSell;
        private UserControls.DecimalTextBox TxtSuggestedPriceToSell;
        private UserControls.DecimalTextBox TxtPricePurchase;
        private System.Windows.Forms.Label lblPricePurchase;
        private System.Windows.Forms.TextBox TxtFilterName;
        private System.Windows.Forms.DataGridView DgvSaleDetail;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label LblTotalSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoodsDetailId;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColGoodsProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoodsPricePurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoodsSuggestedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoodsPVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoodsQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoodsProfit;
        private System.Windows.Forms.DataGridViewImageColumn ColGoodsDelete;
    }
}