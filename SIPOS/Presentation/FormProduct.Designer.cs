
namespace SIPOS.Presentation
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPricePurchase = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.TxtSugestedPriceToSell = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.TxtPriceSell = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtStock = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFilterName = new System.Windows.Forms.TextBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.ColProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductPricePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductSuggestedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductPVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductInvested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColproductActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColProductUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
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
            this.BtnCerrar.Location = new System.Drawing.Point(1086, 11);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 29);
            this.BtnCerrar.TabIndex = 22;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.lbl_login.Location = new System.Drawing.Point(420, 11);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(150, 35);
            this.lbl_login.TabIndex = 23;
            this.lbl_login.Text = "PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(201, 112);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(248, 27);
            this.TxtName.TabIndex = 0;
            this.TxtName.Tag = "required";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(201, 145);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(248, 27);
            this.TxtDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "PVP sugerido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "PVP";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(201, 319);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(90, 33);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvProducts
            // 
            this.DgvProducts.AllowUserToAddRows = false;
            this.DgvProducts.AllowUserToDeleteRows = false;
            this.DgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductId,
            this.ColProductName,
            this.ColProductDescription,
            this.ColProductPricePurchase,
            this.ColProductSuggestedPrice,
            this.ColProductPVP,
            this.ColProductStock,
            this.ColProductInvested,
            this.ColProductProfit,
            this.ColproductActive,
            this.ColProductUpdate});
            this.DgvProducts.Location = new System.Drawing.Point(12, 420);
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.RowHeadersWidth = 49;
            this.DgvProducts.RowTemplate.Height = 28;
            this.DgvProducts.ShowCellToolTips = false;
            this.DgvProducts.Size = new System.Drawing.Size(1104, 309);
            this.DgvProducts.TabIndex = 33;
            this.DgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct_CellContentClick);
            this.DgvProducts.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct_CellMouseEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Precio de compra";
            // 
            // TxtPricePurchase
            // 
            this.TxtPricePurchase.DecimalPlaces = 4;
            this.TxtPricePurchase.Location = new System.Drawing.Point(201, 176);
            this.TxtPricePurchase.Name = "TxtPricePurchase";
            this.TxtPricePurchase.Size = new System.Drawing.Size(248, 27);
            this.TxtPricePurchase.TabIndex = 2;
            this.TxtPricePurchase.Tag = "required";
            // 
            // TxtSugestedPriceToSell
            // 
            this.TxtSugestedPriceToSell.DecimalPlaces = 4;
            this.TxtSugestedPriceToSell.Location = new System.Drawing.Point(201, 209);
            this.TxtSugestedPriceToSell.Name = "TxtSugestedPriceToSell";
            this.TxtSugestedPriceToSell.Size = new System.Drawing.Size(248, 27);
            this.TxtSugestedPriceToSell.TabIndex = 3;
            // 
            // TxtPriceSell
            // 
            this.TxtPriceSell.DecimalPlaces = 4;
            this.TxtPriceSell.Location = new System.Drawing.Point(201, 243);
            this.TxtPriceSell.Name = "TxtPriceSell";
            this.TxtPriceSell.Size = new System.Drawing.Size(248, 27);
            this.TxtPriceSell.TabIndex = 4;
            this.TxtPriceSell.Tag = "required";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 200;
            this.errorProvider.ContainerControl = this;
            // 
            // TxtStock
            // 
            this.TxtStock.DecimalPlaces = 4;
            this.TxtStock.Location = new System.Drawing.Point(201, 277);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(248, 27);
            this.TxtStock.TabIndex = 5;
            this.TxtStock.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Cantidad";
            // 
            // TxtFilterName
            // 
            this.TxtFilterName.Location = new System.Drawing.Point(54, 386);
            this.TxtFilterName.Name = "TxtFilterName";
            this.TxtFilterName.Size = new System.Drawing.Size(181, 27);
            this.TxtFilterName.TabIndex = 38;
            this.TxtFilterName.Tag = "required";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Image = global::SIPOS.Properties.Resources.filter_16px;
            this.BtnFiltrar.Location = new System.Drawing.Point(241, 387);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(44, 27);
            this.BtnFiltrar.TabIndex = 39;
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // ColProductId
            // 
            this.ColProductId.HeaderText = "SupplierId";
            this.ColProductId.MinimumWidth = 6;
            this.ColProductId.Name = "ColProductId";
            this.ColProductId.Visible = false;
            this.ColProductId.Width = 120;
            // 
            // ColProductName
            // 
            this.ColProductName.HeaderText = "Nombre";
            this.ColProductName.MinimumWidth = 6;
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.Width = 120;
            // 
            // ColProductDescription
            // 
            this.ColProductDescription.HeaderText = "Decripción";
            this.ColProductDescription.MinimumWidth = 6;
            this.ColProductDescription.Name = "ColProductDescription";
            this.ColProductDescription.Width = 120;
            // 
            // ColProductPricePurchase
            // 
            this.ColProductPricePurchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColProductPricePurchase.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColProductPricePurchase.HeaderText = "Precio compra";
            this.ColProductPricePurchase.MinimumWidth = 6;
            this.ColProductPricePurchase.Name = "ColProductPricePurchase";
            this.ColProductPricePurchase.Width = 134;
            // 
            // ColProductSuggestedPrice
            // 
            this.ColProductSuggestedPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColProductSuggestedPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColProductSuggestedPrice.FillWeight = 80F;
            this.ColProductSuggestedPrice.HeaderText = "PVP sugerido";
            this.ColProductSuggestedPrice.MinimumWidth = 6;
            this.ColProductSuggestedPrice.Name = "ColProductSuggestedPrice";
            this.ColProductSuggestedPrice.Width = 125;
            // 
            // ColProductPVP
            // 
            this.ColProductPVP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColProductPVP.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColProductPVP.HeaderText = "PVP";
            this.ColProductPVP.MinimumWidth = 6;
            this.ColProductPVP.Name = "ColProductPVP";
            this.ColProductPVP.Width = 63;
            // 
            // ColProductStock
            // 
            this.ColProductStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColProductStock.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColProductStock.HeaderText = "Stock";
            this.ColProductStock.MinimumWidth = 6;
            this.ColProductStock.Name = "ColProductStock";
            this.ColProductStock.ReadOnly = true;
            this.ColProductStock.Width = 74;
            // 
            // ColProductInvested
            // 
            this.ColProductInvested.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColProductInvested.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColProductInvested.HeaderText = "Invertido";
            this.ColProductInvested.MinimumWidth = 6;
            this.ColProductInvested.Name = "ColProductInvested";
            this.ColProductInvested.ReadOnly = true;
            this.ColProductInvested.Width = 97;
            // 
            // ColProductProfit
            // 
            this.ColProductProfit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColProductProfit.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColProductProfit.HeaderText = "Ganancia";
            this.ColProductProfit.MinimumWidth = 6;
            this.ColProductProfit.Name = "ColProductProfit";
            this.ColProductProfit.ReadOnly = true;
            this.ColProductProfit.Width = 99;
            // 
            // ColproductActive
            // 
            this.ColproductActive.HeaderText = "Activo";
            this.ColproductActive.MinimumWidth = 6;
            this.ColproductActive.Name = "ColproductActive";
            this.ColproductActive.Width = 60;
            // 
            // ColProductUpdate
            // 
            this.ColProductUpdate.HeaderText = "";
            this.ColProductUpdate.Image = global::SIPOS.Properties.Resources.save_16px;
            this.ColProductUpdate.MinimumWidth = 6;
            this.ColProductUpdate.Name = "ColProductUpdate";
            this.ColProductUpdate.Width = 50;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 742);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.TxtFilterName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtPriceSell);
            this.Controls.Add(this.TxtSugestedPriceToSell);
            this.Controls.Add(this.TxtPricePurchase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DgvProducts);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.BtnCerrar);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.Label label5;
        private UserControls.DecimalTextBox TxtPricePurchase;
        private UserControls.DecimalTextBox TxtSugestedPriceToSell;
        private UserControls.DecimalTextBox TxtPriceSell;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label6;
        private UserControls.DecimalTextBox TxtStock;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.TextBox TxtFilterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductPricePurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductSuggestedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductPVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductInvested;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductProfit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColproductActive;
        private System.Windows.Forms.DataGridViewImageColumn ColProductUpdate;
    }
}