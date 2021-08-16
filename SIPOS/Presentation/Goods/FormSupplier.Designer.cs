
namespace SIPOS.Presentation.Goods
{
    partial class FormSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplier));
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdentificaion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvSuppliers = new System.Windows.Forms.DataGridView();
            this.ColSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSupplierIdentification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSupplierPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSupplierEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSupplierActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColSupplierUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSuppliers)).BeginInit();
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
            this.BtnCerrar.Location = new System.Drawing.Point(928, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 28);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.lbl_login.Location = new System.Drawing.Point(418, 12);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(157, 32);
            this.lbl_login.TabIndex = 11;
            this.lbl_login.Text = "PROVEEDOR";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(199, 108);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(248, 26);
            this.TxtName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // TxtIdentificaion
            // 
            this.TxtIdentificaion.Location = new System.Drawing.Point(199, 140);
            this.TxtIdentificaion.Name = "TxtIdentificaion";
            this.TxtIdentificaion.Size = new System.Drawing.Size(248, 26);
            this.TxtIdentificaion.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "RUC";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(199, 172);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(248, 26);
            this.TxtPhone.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Teléfono";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(199, 204);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(248, 26);
            this.TxtEmail.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Correo electrónico";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(199, 236);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(90, 31);
            this.BtnAgregar.TabIndex = 20;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvSuppliers
            // 
            this.DgvSuppliers.AllowUserToAddRows = false;
            this.DgvSuppliers.AllowUserToDeleteRows = false;
            this.DgvSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSupplierId,
            this.ColSupplierName,
            this.ColSupplierIdentification,
            this.ColSupplierPhone,
            this.ColSupplierEmail,
            this.ColSupplierActive,
            this.ColSupplierUpdate});
            this.DgvSuppliers.Location = new System.Drawing.Point(12, 311);
            this.DgvSuppliers.Name = "DgvSuppliers";
            this.DgvSuppliers.RowHeadersWidth = 49;
            this.DgvSuppliers.RowTemplate.Height = 28;
            this.DgvSuppliers.ShowCellToolTips = false;
            this.DgvSuppliers.Size = new System.Drawing.Size(946, 269);
            this.DgvSuppliers.TabIndex = 21;
            this.DgvSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSuppliers_CellContentClick);
            this.DgvSuppliers.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSuppliers_CellMouseEnter);
            // 
            // ColSupplierId
            // 
            this.ColSupplierId.HeaderText = "SupplierId";
            this.ColSupplierId.MinimumWidth = 6;
            this.ColSupplierId.Name = "ColSupplierId";
            this.ColSupplierId.Visible = false;
            this.ColSupplierId.Width = 120;
            // 
            // ColSupplierName
            // 
            this.ColSupplierName.HeaderText = "Nombre";
            this.ColSupplierName.MinimumWidth = 6;
            this.ColSupplierName.Name = "ColSupplierName";
            this.ColSupplierName.Width = 120;
            // 
            // ColSupplierIdentification
            // 
            this.ColSupplierIdentification.HeaderText = "RUC";
            this.ColSupplierIdentification.MinimumWidth = 6;
            this.ColSupplierIdentification.Name = "ColSupplierIdentification";
            this.ColSupplierIdentification.Width = 120;
            // 
            // ColSupplierPhone
            // 
            this.ColSupplierPhone.HeaderText = "Teléfono";
            this.ColSupplierPhone.MinimumWidth = 6;
            this.ColSupplierPhone.Name = "ColSupplierPhone";
            this.ColSupplierPhone.Width = 120;
            // 
            // ColSupplierEmail
            // 
            this.ColSupplierEmail.HeaderText = "Email";
            this.ColSupplierEmail.MinimumWidth = 6;
            this.ColSupplierEmail.Name = "ColSupplierEmail";
            this.ColSupplierEmail.Width = 120;
            // 
            // ColSupplierActive
            // 
            this.ColSupplierActive.HeaderText = "Activo";
            this.ColSupplierActive.MinimumWidth = 6;
            this.ColSupplierActive.Name = "ColSupplierActive";
            this.ColSupplierActive.Width = 120;
            // 
            // ColSupplierUpdate
            // 
            this.ColSupplierUpdate.HeaderText = "Actualizar";
            this.ColSupplierUpdate.Image = global::SIPOS.Properties.Resources.save_16px;
            this.ColSupplierUpdate.MinimumWidth = 6;
            this.ColSupplierUpdate.Name = "ColSupplierUpdate";
            this.ColSupplierUpdate.Width = 120;
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 592);
            this.Controls.Add(this.DgvSuppliers);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIdentificaion);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.BtnCerrar);
            this.Name = "FormSupplier";
            this.Text = "SuplierForm";
            this.Load += new System.EventHandler(this.FormSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdentificaion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSupplierIdentification;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSupplierPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSupplierEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSupplierActive;
        private System.Windows.Forms.DataGridViewImageColumn ColSupplierUpdate;
    }
}