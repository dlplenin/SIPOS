﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoodsOrder));
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtQty = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtPriceSell = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.TxtSugestedPriceToSell = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.TxtPricePurchase = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.lblPricePurchase = new System.Windows.Forms.Label();
            this.TxtFilterName = new System.Windows.Forms.TextBox();
            this.DgvGoods = new System.Windows.Forms.DataGridView();
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CbSuppliers = new System.Windows.Forms.ComboBox();
            this.DtpInvoice = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.CbProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TxtCurrentPricePurchase = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.LblCurrentPricePurchace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoods)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.BtnFiltrar.TabIndex = 57;
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
            this.TxtQty.Size = new System.Drawing.Size(50, 26);
            this.TxtQty.TabIndex = 45;
            this.TxtQty.Tag = "required";
            this.TxtQty.Text = "1";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 200;
            this.errorProvider.ContainerControl = this;
            // 
            // TxtPriceSell
            // 
            this.TxtPriceSell.DecimalPlaces = 4;
            this.TxtPriceSell.Location = new System.Drawing.Point(700, 280);
            this.TxtPriceSell.Name = "TxtPriceSell";
            this.TxtPriceSell.Size = new System.Drawing.Size(70, 26);
            this.TxtPriceSell.TabIndex = 44;
            this.TxtPriceSell.Tag = "required";
            // 
            // TxtSugestedPriceToSell
            // 
            this.TxtSugestedPriceToSell.DecimalPlaces = 4;
            this.TxtSugestedPriceToSell.Location = new System.Drawing.Point(550, 280);
            this.TxtSugestedPriceToSell.Name = "TxtSugestedPriceToSell";
            this.TxtSugestedPriceToSell.Size = new System.Drawing.Size(70, 26);
            this.TxtSugestedPriceToSell.TabIndex = 43;
            // 
            // TxtPricePurchase
            // 
            this.TxtPricePurchase.DecimalPlaces = 4;
            this.TxtPricePurchase.Location = new System.Drawing.Point(347, 280);
            this.TxtPricePurchase.Name = "TxtPricePurchase";
            this.TxtPricePurchase.Size = new System.Drawing.Size(70, 26);
            this.TxtPricePurchase.TabIndex = 42;
            this.TxtPricePurchase.Tag = "required";
            // 
            // lblPricePurchase
            // 
            this.lblPricePurchase.AutoSize = true;
            this.lblPricePurchase.Location = new System.Drawing.Point(315, 283);
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
            this.TxtFilterName.TabIndex = 56;
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
            this.DgvGoods.RowHeadersWidth = 49;
            this.DgvGoods.RowTemplate.Height = 28;
            this.DgvGoods.ShowCellToolTips = false;
            this.DgvGoods.Size = new System.Drawing.Size(1253, 318);
            this.DgvGoods.TabIndex = 53;
            // 
            // ColGoodsDetailId
            // 
            this.ColGoodsDetailId.HeaderText = "GoodsDetailId";
            this.ColGoodsDetailId.MinimumWidth = 6;
            this.ColGoodsDetailId.Name = "ColGoodsDetailId";
            this.ColGoodsDetailId.Visible = false;
            this.ColGoodsDetailId.Width = 120;
            // 
            // ColGoodsProduct
            // 
            this.ColGoodsProduct.HeaderText = "Producto";
            this.ColGoodsProduct.MinimumWidth = 6;
            this.ColGoodsProduct.Name = "ColGoodsProduct";
            this.ColGoodsProduct.Width = 120;
            // 
            // ColGoodsPricePurchase
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsPricePurchase.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColGoodsPricePurchase.HeaderText = "Precio compra";
            this.ColGoodsPricePurchase.MinimumWidth = 6;
            this.ColGoodsPricePurchase.Name = "ColGoodsPricePurchase";
            this.ColGoodsPricePurchase.Width = 120;
            // 
            // ColGoodsSuggestedPrice
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsSuggestedPrice.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColGoodsSuggestedPrice.HeaderText = "PVP sugerido";
            this.ColGoodsSuggestedPrice.MinimumWidth = 6;
            this.ColGoodsSuggestedPrice.Name = "ColGoodsSuggestedPrice";
            this.ColGoodsSuggestedPrice.Width = 120;
            // 
            // ColGoodsPVP
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsPVP.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColGoodsPVP.HeaderText = "PVP";
            this.ColGoodsPVP.MinimumWidth = 6;
            this.ColGoodsPVP.Name = "ColGoodsPVP";
            this.ColGoodsPVP.Width = 120;
            // 
            // ColGoodsQty
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsQty.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColGoodsQty.HeaderText = "Cantidad";
            this.ColGoodsQty.MinimumWidth = 6;
            this.ColGoodsQty.Name = "ColGoodsQty";
            this.ColGoodsQty.ReadOnly = true;
            this.ColGoodsQty.Width = 120;
            // 
            // ColGoodsInvested
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsInvested.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColGoodsInvested.HeaderText = "Invertido";
            this.ColGoodsInvested.MinimumWidth = 6;
            this.ColGoodsInvested.Name = "ColGoodsInvested";
            this.ColGoodsInvested.ReadOnly = true;
            this.ColGoodsInvested.Width = 120;
            // 
            // ColGoodsProfit
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColGoodsProfit.DefaultCellStyle = dataGridViewCellStyle12;
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
            this.ColGoodsUpdate.Width = 120;
            // 
            // ColGoodsDelete
            // 
            this.ColGoodsDelete.HeaderText = "Eliminar";
            this.ColGoodsDelete.Image = global::SIPOS.Properties.Resources.eraser_16px;
            this.ColGoodsDelete.MinimumWidth = 6;
            this.ColGoodsDelete.Name = "ColGoodsDelete";
            this.ColGoodsDelete.Width = 120;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(833, 275);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(140, 31);
            this.BtnAgregar.TabIndex = 46;
            this.BtnAgregar.Text = "Agregar producto";
            this.BtnAgregar.UseVisualStyleBackColor = true;
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
            this.label3.Location = new System.Drawing.Point(448, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "PVP sugerido";
            // 
            // TxtFactura
            // 
            this.TxtFactura.Location = new System.Drawing.Point(89, 28);
            this.TxtFactura.Name = "TxtFactura";
            this.TxtFactura.Size = new System.Drawing.Size(248, 26);
            this.TxtFactura.TabIndex = 40;
            this.TxtFactura.Tag = "required";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
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
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CbSuppliers);
            this.groupBox1.Controls.Add(this.DtpInvoice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtNotes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LblTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtFactura);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1019, 161);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura/Orden";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "Proveedor";
            // 
            // CbSuppliers
            // 
            this.CbSuppliers.FormattingEnabled = true;
            this.CbSuppliers.Location = new System.Drawing.Point(89, 60);
            this.CbSuppliers.Name = "CbSuppliers";
            this.CbSuppliers.Size = new System.Drawing.Size(248, 27);
            this.CbSuppliers.TabIndex = 59;
            // 
            // DtpInvoice
            // 
            this.DtpInvoice.Location = new System.Drawing.Point(472, 28);
            this.DtpInvoice.Name = "DtpInvoice";
            this.DtpInvoice.Size = new System.Drawing.Size(286, 26);
            this.DtpInvoice.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 31);
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
            this.TxtNotes.TabIndex = 52;
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
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotal.ForeColor = System.Drawing.Color.IndianRed;
            this.LblTotal.Location = new System.Drawing.Point(821, 31);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(26, 31);
            this.LblTotal.TabIndex = 50;
            this.LblTotal.Text = "$";
            // 
            // CbProducts
            // 
            this.CbProducts.FormattingEnabled = true;
            this.CbProducts.Location = new System.Drawing.Point(101, 247);
            this.CbProducts.Name = "CbProducts";
            this.CbProducts.Size = new System.Drawing.Size(669, 27);
            this.CbProducts.TabIndex = 61;
            this.CbProducts.SelectedIndexChanged += new System.EventHandler(this.CbProducts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "PVP";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1136, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 31);
            this.button1.TabIndex = 63;
            this.button1.Text = "Guardar factura";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtCurrentPricePurchase
            // 
            this.TxtCurrentPricePurchase.DecimalPlaces = 4;
            this.TxtCurrentPricePurchase.Location = new System.Drawing.Point(225, 280);
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
            this.LblCurrentPricePurchace.Location = new System.Drawing.Point(183, 283);
            this.LblCurrentPricePurchace.Name = "LblCurrentPricePurchace";
            this.LblCurrentPricePurchace.Size = new System.Drawing.Size(36, 20);
            this.LblCurrentPricePurchace.TabIndex = 65;
            this.LblCurrentPricePurchace.Text = "PCA";
            // 
            // FormGoodsOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 711);
            this.Controls.Add(this.TxtCurrentPricePurchase);
            this.Controls.Add(this.LblCurrentPricePurchace);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbProducts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.TxtPriceSell);
            this.Controls.Add(this.TxtSugestedPriceToSell);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoods)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label label6;
        private UserControls.DecimalTextBox TxtQty;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private UserControls.DecimalTextBox TxtPriceSell;
        private UserControls.DecimalTextBox TxtSugestedPriceToSell;
        private UserControls.DecimalTextBox TxtPricePurchase;
        private System.Windows.Forms.Label lblPricePurchase;
        private System.Windows.Forms.TextBox TxtFilterName;
        private System.Windows.Forms.DataGridView DgvGoods;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpInvoice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbSuppliers;
        private System.Windows.Forms.ComboBox CbProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.ToolTip toolTip;
        private UserControls.DecimalTextBox TxtCurrentPricePurchase;
        private System.Windows.Forms.Label LblCurrentPricePurchace;
    }
}