
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSugestedPriceToSell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPriceSell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.ColProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductPricePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductSuggestedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductPVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColproductActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColProductUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.TxtPricePurchase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
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
            this.BtnCerrar.Location = new System.Drawing.Point(963, 10);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 28);
            this.BtnCerrar.TabIndex = 22;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.lbl_login.Location = new System.Drawing.Point(420, 10);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(144, 32);
            this.lbl_login.TabIndex = 23;
            this.lbl_login.Text = "PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(201, 106);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(248, 26);
            this.TxtName.TabIndex = 25;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(201, 138);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(248, 26);
            this.TxtDescription.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Descripción";
            // 
            // TxtSugestedPriceToSell
            // 
            this.TxtSugestedPriceToSell.Location = new System.Drawing.Point(201, 202);
            this.TxtSugestedPriceToSell.Name = "TxtSugestedPriceToSell";
            this.TxtSugestedPriceToSell.Size = new System.Drawing.Size(248, 26);
            this.TxtSugestedPriceToSell.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "PVP sugerido";
            // 
            // TxtPriceSell
            // 
            this.TxtPriceSell.Location = new System.Drawing.Point(201, 234);
            this.TxtPriceSell.Name = "TxtPriceSell";
            this.TxtPriceSell.Size = new System.Drawing.Size(248, 26);
            this.TxtPriceSell.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "PVP";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(201, 266);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(90, 31);
            this.BtnAgregar.TabIndex = 32;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvProducts
            // 
            this.DgvProducts.AllowUserToAddRows = false;
            this.DgvProducts.AllowUserToDeleteRows = false;
            this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductId,
            this.ColProductName,
            this.ColProductDescription,
            this.ColProductPricePurchase,
            this.ColProductSuggestedPrice,
            this.ColProductPVP,
            this.ColproductActive,
            this.ColProductUpdate});
            this.DgvProducts.Location = new System.Drawing.Point(12, 327);
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.RowHeadersWidth = 49;
            this.DgvProducts.RowTemplate.Height = 28;
            this.DgvProducts.ShowCellToolTips = false;
            this.DgvProducts.Size = new System.Drawing.Size(975, 250);
            this.DgvProducts.TabIndex = 33;
            this.DgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct_CellContentClick);
            this.DgvProducts.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct_CellMouseEnter);
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
            this.ColProductPricePurchase.HeaderText = "Precio compra";
            this.ColProductPricePurchase.MinimumWidth = 6;
            this.ColProductPricePurchase.Name = "ColProductPricePurchase";
            this.ColProductPricePurchase.Width = 120;
            // 
            // ColProductSuggestedPrice
            // 
            this.ColProductSuggestedPrice.HeaderText = "PVP sugerido";
            this.ColProductSuggestedPrice.MinimumWidth = 6;
            this.ColProductSuggestedPrice.Name = "ColProductSuggestedPrice";
            this.ColProductSuggestedPrice.Width = 120;
            // 
            // ColProductPVP
            // 
            this.ColProductPVP.HeaderText = "PVP";
            this.ColProductPVP.MinimumWidth = 6;
            this.ColProductPVP.Name = "ColProductPVP";
            this.ColProductPVP.Width = 120;
            // 
            // ColproductActive
            // 
            this.ColproductActive.HeaderText = "Activo";
            this.ColproductActive.MinimumWidth = 6;
            this.ColproductActive.Name = "ColproductActive";
            this.ColproductActive.Width = 120;
            // 
            // ColProductUpdate
            // 
            this.ColProductUpdate.HeaderText = "Actualizar";
            this.ColProductUpdate.Image = global::SIPOS.Properties.Resources.save_16px;
            this.ColProductUpdate.MinimumWidth = 6;
            this.ColProductUpdate.Name = "ColProductUpdate";
            this.ColProductUpdate.Width = 120;
            // 
            // TxtPricePurchase
            // 
            this.TxtPricePurchase.Location = new System.Drawing.Point(201, 170);
            this.TxtPricePurchase.Name = "TxtPricePurchase";
            this.TxtPricePurchase.Size = new System.Drawing.Size(248, 26);
            this.TxtPricePurchase.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Precio de compra";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 589);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPricePurchase);
            this.Controls.Add(this.DgvProducts);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPriceSell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSugestedPriceToSell);
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
        private System.Windows.Forms.TextBox TxtSugestedPriceToSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPriceSell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.TextBox TxtPricePurchase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductPricePurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductSuggestedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductPVP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColproductActive;
        private System.Windows.Forms.DataGridViewImageColumn ColProductUpdate;
    }
}