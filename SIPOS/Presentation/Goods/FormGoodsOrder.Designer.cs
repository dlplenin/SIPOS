
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoodsOrder));
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtStock = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtPriceSell = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.TxtSugestedPriceToSell = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.TxtPricePurchase = new SIPOS.Presentation.UserControls.DecimalTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ColProductUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColproductActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColProductProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductInvested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductPVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductSuggestedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductPricePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtFilterName = new System.Windows.Forms.TextBox();
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Location = new System.Drawing.Point(317, 363);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(90, 34);
            this.BtnFiltrar.TabIndex = 57;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Cantidad";
            // 
            // TxtStock
            // 
            this.TxtStock.DecimalPlaces = 4;
            this.TxtStock.Location = new System.Drawing.Point(171, 267);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(248, 26);
            this.TxtStock.TabIndex = 45;
            this.TxtStock.Tag = "";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 200;
            this.errorProvider.ContainerControl = this;
            // 
            // TxtPriceSell
            // 
            this.TxtPriceSell.DecimalPlaces = 4;
            this.TxtPriceSell.Location = new System.Drawing.Point(171, 235);
            this.TxtPriceSell.Name = "TxtPriceSell";
            this.TxtPriceSell.Size = new System.Drawing.Size(248, 26);
            this.TxtPriceSell.TabIndex = 44;
            this.TxtPriceSell.Tag = "required";
            // 
            // TxtSugestedPriceToSell
            // 
            this.TxtSugestedPriceToSell.DecimalPlaces = 4;
            this.TxtSugestedPriceToSell.Location = new System.Drawing.Point(171, 203);
            this.TxtSugestedPriceToSell.Name = "TxtSugestedPriceToSell";
            this.TxtSugestedPriceToSell.Size = new System.Drawing.Size(248, 26);
            this.TxtSugestedPriceToSell.TabIndex = 43;
            // 
            // TxtPricePurchase
            // 
            this.TxtPricePurchase.DecimalPlaces = 4;
            this.TxtPricePurchase.Location = new System.Drawing.Point(171, 171);
            this.TxtPricePurchase.Name = "TxtPricePurchase";
            this.TxtPricePurchase.Size = new System.Drawing.Size(248, 26);
            this.TxtPricePurchase.TabIndex = 42;
            this.TxtPricePurchase.Tag = "required";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Precio de compra";
            // 
            // ColProductUpdate
            // 
            this.ColProductUpdate.HeaderText = "Actualizar";
            this.ColProductUpdate.Image = global::SIPOS.Properties.Resources.save_16px;
            this.ColProductUpdate.MinimumWidth = 6;
            this.ColProductUpdate.Name = "ColProductUpdate";
            this.ColProductUpdate.Width = 120;
            // 
            // ColproductActive
            // 
            this.ColproductActive.HeaderText = "Activo";
            this.ColproductActive.MinimumWidth = 6;
            this.ColproductActive.Name = "ColproductActive";
            this.ColproductActive.Width = 120;
            // 
            // ColProductProfit
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColProductProfit.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColProductProfit.HeaderText = "Ganancia";
            this.ColProductProfit.MinimumWidth = 6;
            this.ColProductProfit.Name = "ColProductProfit";
            this.ColProductProfit.ReadOnly = true;
            this.ColProductProfit.Width = 120;
            // 
            // ColProductInvested
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColProductInvested.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColProductInvested.HeaderText = "Invertido";
            this.ColProductInvested.MinimumWidth = 6;
            this.ColProductInvested.Name = "ColProductInvested";
            this.ColProductInvested.ReadOnly = true;
            this.ColProductInvested.Width = 120;
            // 
            // ColProductStock
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColProductStock.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColProductStock.HeaderText = "Stock";
            this.ColProductStock.MinimumWidth = 6;
            this.ColProductStock.Name = "ColProductStock";
            this.ColProductStock.ReadOnly = true;
            this.ColProductStock.Width = 120;
            // 
            // ColProductPVP
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColProductPVP.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColProductPVP.HeaderText = "PVP";
            this.ColProductPVP.MinimumWidth = 6;
            this.ColProductPVP.Name = "ColProductPVP";
            this.ColProductPVP.Width = 120;
            // 
            // ColProductSuggestedPrice
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColProductSuggestedPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColProductSuggestedPrice.HeaderText = "PVP sugerido";
            this.ColProductSuggestedPrice.MinimumWidth = 6;
            this.ColProductSuggestedPrice.Name = "ColProductSuggestedPrice";
            this.ColProductSuggestedPrice.Width = 120;
            // 
            // ColProductPricePurchase
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColProductPricePurchase.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColProductPricePurchase.HeaderText = "Precio compra";
            this.ColProductPricePurchase.MinimumWidth = 6;
            this.ColProductPricePurchase.Name = "ColProductPricePurchase";
            this.ColProductPricePurchase.Width = 120;
            // 
            // ColProductDescription
            // 
            this.ColProductDescription.HeaderText = "Decripción";
            this.ColProductDescription.MinimumWidth = 6;
            this.ColProductDescription.Name = "ColProductDescription";
            this.ColProductDescription.Width = 120;
            // 
            // ColProductName
            // 
            this.ColProductName.HeaderText = "Nombre";
            this.ColProductName.MinimumWidth = 6;
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.Width = 120;
            // 
            // ColProductId
            // 
            this.ColProductId.HeaderText = "SupplierId";
            this.ColProductId.MinimumWidth = 6;
            this.ColProductId.Name = "ColProductId";
            this.ColProductId.Visible = false;
            this.ColProductId.Width = 120;
            // 
            // TxtFilterName
            // 
            this.TxtFilterName.Location = new System.Drawing.Point(24, 371);
            this.TxtFilterName.Name = "TxtFilterName";
            this.TxtFilterName.Size = new System.Drawing.Size(181, 26);
            this.TxtFilterName.TabIndex = 56;
            this.TxtFilterName.Tag = "required";
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
            this.DgvProducts.Location = new System.Drawing.Point(12, 403);
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.RowHeadersWidth = 49;
            this.DgvProducts.RowTemplate.Height = 28;
            this.DgvProducts.ShowCellToolTips = false;
            this.DgvProducts.Size = new System.Drawing.Size(1253, 296);
            this.DgvProducts.TabIndex = 53;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(171, 307);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(90, 31);
            this.BtnAgregar.TabIndex = 46;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "PVP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "PVP sugerido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Descripción";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(171, 142);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(248, 26);
            this.TxtDescription.TabIndex = 41;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(171, 110);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(248, 26);
            this.TxtName.TabIndex = 40;
            this.TxtName.Tag = "required";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nombre";
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
            // FormGoodsOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 711);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtPriceSell);
            this.Controls.Add(this.TxtSugestedPriceToSell);
            this.Controls.Add(this.TxtPricePurchase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtFilterName);
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
            this.Name = "FormGoodsOrder";
            this.Text = "GoodsOrder";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label label6;
        private UserControls.DecimalTextBox TxtStock;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private UserControls.DecimalTextBox TxtPriceSell;
        private UserControls.DecimalTextBox TxtSugestedPriceToSell;
        private UserControls.DecimalTextBox TxtPricePurchase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFilterName;
        private System.Windows.Forms.DataGridView DgvProducts;
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
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button BtnCerrar;
    }
}