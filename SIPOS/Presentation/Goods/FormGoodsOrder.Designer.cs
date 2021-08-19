
namespace SIPOS.Presentation.Goods
{
    partial class FormGoodsOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoodsOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtQty = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.errorProviderProd = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtPriceSell = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.TxtSuggestedPriceToSell = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.TxtPricePurchase = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.lblPricePurchase = new System.Windows.Forms.Label();
            this.TxtFilterName = new System.Windows.Forms.TextBox();
            this.DgvGoods = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtInvoice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTotalProfit = new System.Windows.Forms.Label();
            this.LblTotalInvested = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CbSuppliers = new System.Windows.Forms.ComboBox();
            this.DtpInvoice = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSaveGoodsOrder = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TxtCurrentPricePurchase = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.LblCurrentPricePurchace = new System.Windows.Forms.Label();
            this.TxtStock = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderGoods = new System.Windows.Forms.ErrorProvider(this.components);
            this.ColGoodsDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoodsProduct = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColGoodsPricePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoodsSuggestedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoodsPVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoodsQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoodsInvested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoodsProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoodsUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColGoodsDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoods)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackgroundImage = global::SIPOS.Properties.Resources.filter_16px;
            this.BtnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Location = new System.Drawing.Point(215, 349);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(44, 26);
            this.BtnFiltrar.TabIndex = 14;
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Cantidad";
            // 
            // TxtQty
            // 
            this.TxtQty.DecimalPlaces = 4;
            this.TxtQty.Location = new System.Drawing.Point(101, 280);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(76, 26);
            this.TxtQty.TabIndex = 6;
            this.TxtQty.Tag = "requiredProd";
            this.TxtQty.Text = "1";
            // 
            // errorProviderProd
            // 
            this.errorProviderProd.BlinkRate = 200;
            this.errorProviderProd.ContainerControl = this;
            // 
            // TxtPriceSell
            // 
            this.TxtPriceSell.DecimalPlaces = 4;
            this.TxtPriceSell.Location = new System.Drawing.Point(777, 280);
            this.TxtPriceSell.Name = "TxtPriceSell";
            this.TxtPriceSell.Size = new System.Drawing.Size(70, 26);
            this.TxtPriceSell.TabIndex = 9;
            this.TxtPriceSell.Tag = "requiredProd";
            // 
            // TxtSuggestedPriceToSell
            // 
            this.TxtSuggestedPriceToSell.DecimalPlaces = 4;
            this.TxtSuggestedPriceToSell.Location = new System.Drawing.Point(627, 280);
            this.TxtSuggestedPriceToSell.Name = "TxtSuggestedPriceToSell";
            this.TxtSuggestedPriceToSell.Size = new System.Drawing.Size(70, 26);
            this.TxtSuggestedPriceToSell.TabIndex = 8;
            // 
            // TxtPricePurchase
            // 
            this.TxtPricePurchase.DecimalPlaces = 4;
            this.TxtPricePurchase.Location = new System.Drawing.Point(424, 280);
            this.TxtPricePurchase.Name = "TxtPricePurchase";
            this.TxtPricePurchase.Size = new System.Drawing.Size(70, 26);
            this.TxtPricePurchase.TabIndex = 7;
            this.TxtPricePurchase.Tag = "requiredProd";
            // 
            // lblPricePurchase
            // 
            this.lblPricePurchase.AutoSize = true;
            this.lblPricePurchase.Location = new System.Drawing.Point(392, 283);
            this.lblPricePurchase.Name = "lblPricePurchase";
            this.lblPricePurchase.Size = new System.Drawing.Size(26, 20);
            this.lblPricePurchase.TabIndex = 54;
            this.lblPricePurchase.Text = "PC";
            // 
            // TxtFilterName
            // 
            this.TxtFilterName.Location = new System.Drawing.Point(16, 349);
            this.TxtFilterName.Name = "TxtFilterName";
            this.TxtFilterName.Size = new System.Drawing.Size(193, 26);
            this.TxtFilterName.TabIndex = 13;
            this.TxtFilterName.Tag = "required";
            // 
            // DgvGoods
            // 
            this.DgvGoods.AllowUserToAddRows = false;
            this.DgvGoods.AllowUserToDeleteRows = false;
            this.DgvGoods.AllowUserToOrderColumns = true;
            this.DgvGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColGoodsDetailId,
            this.ColGoodsProduct,
            this.ColGoodsPricePurchase,
            this.ColGoodsSuggestedPrice,
            this.ColGoodsPVP,
            this.ColGoodsQty,
            this.ColGoodsInvested,
            this.ColGoodsProfit,
            this.ColGoodsUpdate,
            this.ColGoodsDelete});
            this.DgvGoods.Location = new System.Drawing.Point(12, 381);
            this.DgvGoods.Name = "DgvGoods";
            this.DgvGoods.ReadOnly = true;
            this.DgvGoods.RowHeadersWidth = 49;
            this.DgvGoods.RowTemplate.Height = 28;
            this.DgvGoods.ShowCellToolTips = false;
            this.DgvGoods.Size = new System.Drawing.Size(1253, 318);
            this.DgvGoods.TabIndex = 12;
            this.DgvGoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGoods_CellContentClick);
            this.DgvGoods.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGoods_CellMouseEnter);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Image = global::SIPOS.Properties.Resources.add_64px;
            this.BtnAgregar.Location = new System.Drawing.Point(880, 247);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(69, 64);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "PVP sugerido";
            // 
            // TxtInvoice
            // 
            this.TxtInvoice.Location = new System.Drawing.Point(90, 61);
            this.TxtInvoice.Name = "TxtInvoice";
            this.TxtInvoice.Size = new System.Drawing.Size(248, 26);
            this.TxtInvoice.TabIndex = 2;
            this.TxtInvoice.Tag = "requiredGoodsOrder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Factura";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.lbl_login.Location = new System.Drawing.Point(390, 14);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(319, 32);
            this.lbl_login.TabIndex = 48;
            this.lbl_login.Text = "COMPRA DE MERCADERÍA";
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
            this.BtnCerrar.Location = new System.Drawing.Point(1235, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 28);
            this.BtnCerrar.TabIndex = 47;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblTotalProfit);
            this.groupBox1.Controls.Add(this.LblTotalInvested);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CbSuppliers);
            this.groupBox1.Controls.Add(this.DtpInvoice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtNotes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtInvoice);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 161);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura/Orden";
            // 
            // LblTotalProfit
            // 
            this.LblTotalProfit.AutoSize = true;
            this.LblTotalProfit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotalProfit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblTotalProfit.Location = new System.Drawing.Point(784, 93);
            this.LblTotalProfit.Name = "LblTotalProfit";
            this.LblTotalProfit.Size = new System.Drawing.Size(29, 36);
            this.LblTotalProfit.TabIndex = 62;
            this.LblTotalProfit.Text = "$";
            // 
            // LblTotalInvested
            // 
            this.LblTotalInvested.AutoSize = true;
            this.LblTotalInvested.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotalInvested.ForeColor = System.Drawing.Color.IndianRed;
            this.LblTotalInvested.Location = new System.Drawing.Point(780, 33);
            this.LblTotalInvested.Name = "LblTotalInvested";
            this.LblTotalInvested.Size = new System.Drawing.Size(37, 45);
            this.LblTotalInvested.TabIndex = 61;
            this.LblTotalInvested.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "Proveedor";
            // 
            // CbSuppliers
            // 
            this.CbSuppliers.FormattingEnabled = true;
            this.CbSuppliers.Location = new System.Drawing.Point(90, 28);
            this.CbSuppliers.Name = "CbSuppliers";
            this.CbSuppliers.Size = new System.Drawing.Size(248, 27);
            this.CbSuppliers.TabIndex = 1;
            // 
            // DtpInvoice
            // 
            this.DtpInvoice.Location = new System.Drawing.Point(473, 61);
            this.DtpInvoice.Name = "DtpInvoice";
            this.DtpInvoice.Size = new System.Drawing.Size(286, 26);
            this.DtpInvoice.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "Fecha factura";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(89, 93);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(669, 54);
            this.TxtNotes.TabIndex = 4;
            this.TxtNotes.Tag = "required";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Notas";
            // 
            // CbProducts
            // 
            this.CbProducts.FormattingEnabled = true;
            this.CbProducts.Location = new System.Drawing.Point(101, 247);
            this.CbProducts.Name = "CbProducts";
            this.CbProducts.Size = new System.Drawing.Size(560, 27);
            this.CbProducts.TabIndex = 5;
            this.CbProducts.SelectedIndexChanged += new System.EventHandler(this.CbProducts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "PVP";
            // 
            // BtnSaveGoodsOrder
            // 
            this.BtnSaveGoodsOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveGoodsOrder.Image = global::SIPOS.Properties.Resources.add_file_100;
            this.BtnSaveGoodsOrder.Location = new System.Drawing.Point(1168, 280);
            this.BtnSaveGoodsOrder.Name = "BtnSaveGoodsOrder";
            this.BtnSaveGoodsOrder.Size = new System.Drawing.Size(97, 95);
            this.BtnSaveGoodsOrder.TabIndex = 11;
            this.BtnSaveGoodsOrder.UseVisualStyleBackColor = true;
            this.BtnSaveGoodsOrder.Click += new System.EventHandler(this.BtnSaveGoodsOrder_Click);
            // 
            // TxtCurrentPricePurchase
            // 
            this.TxtCurrentPricePurchase.DecimalPlaces = 4;
            this.TxtCurrentPricePurchase.Location = new System.Drawing.Point(302, 280);
            this.TxtCurrentPricePurchase.Name = "TxtCurrentPricePurchase";
            this.TxtCurrentPricePurchase.ReadOnly = true;
            this.TxtCurrentPricePurchase.Size = new System.Drawing.Size(70, 26);
            this.TxtCurrentPricePurchase.TabIndex = 64;
            this.TxtCurrentPricePurchase.Tag = "required";
            // 
            // LblCurrentPricePurchace
            // 
            this.LblCurrentPricePurchace.AutoSize = true;
            this.LblCurrentPricePurchace.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LblCurrentPricePurchace.Location = new System.Drawing.Point(260, 283);
            this.LblCurrentPricePurchace.Name = "LblCurrentPricePurchace";
            this.LblCurrentPricePurchace.Size = new System.Drawing.Size(36, 20);
            this.LblCurrentPricePurchace.TabIndex = 65;
            this.LblCurrentPricePurchace.Text = "PCA";
            // 
            // TxtStock
            // 
            this.TxtStock.DecimalPlaces = 4;
            this.TxtStock.Location = new System.Drawing.Point(737, 248);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.ReadOnly = true;
            this.TxtStock.Size = new System.Drawing.Size(110, 26);
            this.TxtStock.TabIndex = 66;
            this.TxtStock.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(686, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Stock";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 200;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkRate = 200;
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProviderGoods
            // 
            this.errorProviderGoods.ContainerControl = this;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsPricePurchase.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColGoodsPricePurchase.HeaderText = "Precio compra";
            this.ColGoodsPricePurchase.MinimumWidth = 6;
            this.ColGoodsPricePurchase.Name = "ColGoodsPricePurchase";
            this.ColGoodsPricePurchase.ReadOnly = true;
            this.ColGoodsPricePurchase.Width = 120;
            // 
            // ColGoodsSuggestedPrice
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsSuggestedPrice.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColGoodsSuggestedPrice.HeaderText = "PVP sugerido";
            this.ColGoodsSuggestedPrice.MinimumWidth = 6;
            this.ColGoodsSuggestedPrice.Name = "ColGoodsSuggestedPrice";
            this.ColGoodsSuggestedPrice.ReadOnly = true;
            this.ColGoodsSuggestedPrice.Width = 120;
            // 
            // ColGoodsPVP
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsPVP.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColGoodsPVP.HeaderText = "PVP";
            this.ColGoodsPVP.MinimumWidth = 6;
            this.ColGoodsPVP.Name = "ColGoodsPVP";
            this.ColGoodsPVP.ReadOnly = true;
            this.ColGoodsPVP.Width = 120;
            // 
            // ColGoodsQty
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsQty.DefaultCellStyle = dataGridViewCellStyle16;
            this.ColGoodsQty.HeaderText = "Cantidad";
            this.ColGoodsQty.MinimumWidth = 6;
            this.ColGoodsQty.Name = "ColGoodsQty";
            this.ColGoodsQty.ReadOnly = true;
            this.ColGoodsQty.Width = 120;
            // 
            // ColGoodsInvested
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsInvested.DefaultCellStyle = dataGridViewCellStyle17;
            this.ColGoodsInvested.HeaderText = "Invertido";
            this.ColGoodsInvested.MinimumWidth = 6;
            this.ColGoodsInvested.Name = "ColGoodsInvested";
            this.ColGoodsInvested.ReadOnly = true;
            this.ColGoodsInvested.Width = 120;
            // 
            // ColGoodsProfit
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsProfit.DefaultCellStyle = dataGridViewCellStyle18;
            this.ColGoodsProfit.HeaderText = "Ganancia";
            this.ColGoodsProfit.MinimumWidth = 6;
            this.ColGoodsProfit.Name = "ColGoodsProfit";
            this.ColGoodsProfit.ReadOnly = true;
            this.ColGoodsProfit.Width = 120;
            // 
            // ColGoodsUpdate
            // 
            this.ColGoodsUpdate.HeaderText = "Actualizar";
            this.ColGoodsUpdate.Image = global::SIPOS.Properties.Resources.save_16px;
            this.ColGoodsUpdate.MinimumWidth = 6;
            this.ColGoodsUpdate.Name = "ColGoodsUpdate";
            this.ColGoodsUpdate.ReadOnly = true;
            this.ColGoodsUpdate.Visible = false;
            this.ColGoodsUpdate.Width = 120;
            // 
            // ColGoodsDelete
            // 
            this.ColGoodsDelete.HeaderText = "Eliminar";
            this.ColGoodsDelete.Image = global::SIPOS.Properties.Resources.eraser_16px;
            this.ColGoodsDelete.MinimumWidth = 6;
            this.ColGoodsDelete.Name = "ColGoodsDelete";
            this.ColGoodsDelete.ReadOnly = true;
            this.ColGoodsDelete.Width = 120;
            // 
            // FormGoodsOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 711);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCurrentPricePurchase);
            this.Controls.Add(this.LblCurrentPricePurchace);
            this.Controls.Add(this.BtnSaveGoodsOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbProducts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.TxtPriceSell);
            this.Controls.Add(this.TxtSuggestedPriceToSell);
            this.Controls.Add(this.TxtPricePurchase);
            this.Controls.Add(this.lblPricePurchase);
            this.Controls.Add(this.TxtFilterName);
            this.Controls.Add(this.DgvGoods);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.BtnCerrar);
            this.Name = "FormGoodsOrder";
            this.Text = "GoodsOrder";
            this.Load += new System.EventHandler(this.FormGoodsOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoods)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label label6;
        private UserControls.DecimalTextBox TxtQty;
        private System.Windows.Forms.ErrorProvider errorProviderProd;
        private UserControls.DecimalTextBox TxtPriceSell;
        private UserControls.DecimalTextBox TxtSuggestedPriceToSell;
        private UserControls.DecimalTextBox TxtPricePurchase;
        private System.Windows.Forms.Label lblPricePurchase;
        private System.Windows.Forms.TextBox TxtFilterName;
        private System.Windows.Forms.DataGridView DgvGoods;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtInvoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpInvoice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbSuppliers;
        private System.Windows.Forms.ComboBox CbProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSaveGoodsOrder;
        private System.Windows.Forms.ToolTip toolTip;
        private UserControls.DecimalTextBox TxtCurrentPricePurchase;
        private System.Windows.Forms.Label LblCurrentPricePurchace;
        private UserControls.DecimalTextBox TxtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblTotalInvested;
        private System.Windows.Forms.Label LblTotalProfit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProviderGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoodsDetailId;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColGoodsProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoodsPricePurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoodsSuggestedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoodsPVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoodsQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoodsInvested;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoodsProfit;
        private System.Windows.Forms.DataGridViewImageColumn ColGoodsUpdate;
        private System.Windows.Forms.DataGridViewImageColumn ColGoodsDelete;
    }
}