
namespace SIPOS.Presentation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.FormsPanel = new System.Windows.Forms.Panel();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.BtnSalesRegister = new System.Windows.Forms.Button();
            this.BtnGoods = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.BtnSupplier = new System.Windows.Forms.Button();
            this.BtnUsermanagement = new System.Windows.Forms.Button();
            this.TopMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PbRestart = new System.Windows.Forms.PictureBox();
            this.PbMin = new System.Windows.Forms.PictureBox();
            this.PbMax = new System.Windows.Forms.PictureBox();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.ContainerPanel.SuspendLayout();
            this.FormsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.TopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContainerPanel.Controls.Add(this.FormsPanel);
            this.ContainerPanel.Controls.Add(this.MenuPanel);
            this.ContainerPanel.Controls.Add(this.TopMenu);
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(1280, 1024);
            this.ContainerPanel.TabIndex = 0;
            // 
            // FormsPanel
            // 
            this.FormsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.FormsPanel.Controls.Add(this.PbLogo);
            this.FormsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormsPanel.Location = new System.Drawing.Point(240, 42);
            this.FormsPanel.Name = "FormsPanel";
            this.FormsPanel.Size = new System.Drawing.Size(1040, 982);
            this.FormsPanel.TabIndex = 2;
            // 
            // PbLogo
            // 
            this.PbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(0, 0);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(1040, 982);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbLogo.TabIndex = 0;
            this.PbLogo.TabStop = false;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.MenuPanel.Controls.Add(this.BtnSalesRegister);
            this.MenuPanel.Controls.Add(this.BtnGoods);
            this.MenuPanel.Controls.Add(this.BtnProducto);
            this.MenuPanel.Controls.Add(this.BtnSupplier);
            this.MenuPanel.Controls.Add(this.BtnUsermanagement);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 42);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(240, 982);
            this.MenuPanel.TabIndex = 1;
            // 
            // BtnSalesRegister
            // 
            this.BtnSalesRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSalesRegister.FlatAppearance.BorderSize = 0;
            this.BtnSalesRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.BtnSalesRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnSalesRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalesRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSalesRegister.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSalesRegister.Location = new System.Drawing.Point(0, 188);
            this.BtnSalesRegister.Name = "BtnSalesRegister";
            this.BtnSalesRegister.Size = new System.Drawing.Size(240, 47);
            this.BtnSalesRegister.TabIndex = 4;
            this.BtnSalesRegister.Text = "Registro de Ventas";
            this.BtnSalesRegister.UseVisualStyleBackColor = true;
            this.BtnSalesRegister.Click += new System.EventHandler(this.BtnSalesRegister_Click);
            // 
            // BtnGoods
            // 
            this.BtnGoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGoods.FlatAppearance.BorderSize = 0;
            this.BtnGoods.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.BtnGoods.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGoods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGoods.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnGoods.Location = new System.Drawing.Point(0, 141);
            this.BtnGoods.Name = "BtnGoods";
            this.BtnGoods.Size = new System.Drawing.Size(240, 47);
            this.BtnGoods.TabIndex = 3;
            this.BtnGoods.Text = "Recepción Mercadería";
            this.BtnGoods.UseVisualStyleBackColor = true;
            this.BtnGoods.Click += new System.EventHandler(this.BtnGoods_Click);
            // 
            // BtnProducto
            // 
            this.BtnProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProducto.FlatAppearance.BorderSize = 0;
            this.BtnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.BtnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnProducto.Location = new System.Drawing.Point(0, 94);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(240, 47);
            this.BtnProducto.TabIndex = 2;
            this.BtnProducto.Text = "Producto";
            this.BtnProducto.UseVisualStyleBackColor = true;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // BtnSupplier
            // 
            this.BtnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSupplier.FlatAppearance.BorderSize = 0;
            this.BtnSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.BtnSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSupplier.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSupplier.Location = new System.Drawing.Point(0, 47);
            this.BtnSupplier.Name = "BtnSupplier";
            this.BtnSupplier.Size = new System.Drawing.Size(240, 47);
            this.BtnSupplier.TabIndex = 0;
            this.BtnSupplier.Text = "Proveedores";
            this.BtnSupplier.UseVisualStyleBackColor = true;
            this.BtnSupplier.Click += new System.EventHandler(this.BtnSupplier_Click);
            // 
            // BtnUsermanagement
            // 
            this.BtnUsermanagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUsermanagement.FlatAppearance.BorderSize = 0;
            this.BtnUsermanagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.BtnUsermanagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnUsermanagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsermanagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUsermanagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnUsermanagement.Location = new System.Drawing.Point(0, 0);
            this.BtnUsermanagement.Name = "BtnUsermanagement";
            this.BtnUsermanagement.Size = new System.Drawing.Size(240, 47);
            this.BtnUsermanagement.TabIndex = 1;
            this.BtnUsermanagement.Text = "Usuarios";
            this.BtnUsermanagement.UseVisualStyleBackColor = true;
            this.BtnUsermanagement.Click += new System.EventHandler(this.BtnUsermanagement_Click);
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.TopMenu.Controls.Add(this.label2);
            this.TopMenu.Controls.Add(this.PbRestart);
            this.TopMenu.Controls.Add(this.PbMin);
            this.TopMenu.Controls.Add(this.PbMax);
            this.TopMenu.Controls.Add(this.PbClose);
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(1280, 42);
            this.TopMenu.TabIndex = 0;
            this.TopMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopMenu_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Abarrotes San Ignacio - POS";
            // 
            // PbRestart
            // 
            this.PbRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbRestart.Image = ((System.Drawing.Image)(resources.GetObject("PbRestart.Image")));
            this.PbRestart.Location = new System.Drawing.Point(1226, 13);
            this.PbRestart.Name = "PbRestart";
            this.PbRestart.Size = new System.Drawing.Size(16, 17);
            this.PbRestart.TabIndex = 3;
            this.PbRestart.TabStop = false;
            this.PbRestart.Visible = false;
            this.PbRestart.Click += new System.EventHandler(this.PbRestart_Click);
            // 
            // PbMin
            // 
            this.PbMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbMin.Image = ((System.Drawing.Image)(resources.GetObject("PbMin.Image")));
            this.PbMin.Location = new System.Drawing.Point(1200, 13);
            this.PbMin.Name = "PbMin";
            this.PbMin.Size = new System.Drawing.Size(16, 17);
            this.PbMin.TabIndex = 2;
            this.PbMin.TabStop = false;
            this.PbMin.Click += new System.EventHandler(this.PbMin_Click);
            // 
            // PbMax
            // 
            this.PbMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbMax.Image = ((System.Drawing.Image)(resources.GetObject("PbMax.Image")));
            this.PbMax.Location = new System.Drawing.Point(1226, 13);
            this.PbMax.Name = "PbMax";
            this.PbMax.Size = new System.Drawing.Size(16, 17);
            this.PbMax.TabIndex = 1;
            this.PbMax.TabStop = false;
            this.PbMax.Click += new System.EventHandler(this.PbMax_Click);
            // 
            // PbClose
            // 
            this.PbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbClose.Image = ((System.Drawing.Image)(resources.GetObject("PbClose.Image")));
            this.PbClose.Location = new System.Drawing.Point(1252, 13);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(16, 17);
            this.PbClose.TabIndex = 0;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.ContainerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(680, 526);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ContainerPanel.ResumeLayout(false);
            this.FormsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Panel FormsPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel TopMenu;
        private System.Windows.Forms.PictureBox PbMax;
        private System.Windows.Forms.PictureBox PbClose;
        private System.Windows.Forms.PictureBox PbMin;
        private System.Windows.Forms.PictureBox PbRestart;
        private System.Windows.Forms.Button BtnSupplier;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnUsermanagement;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button BtnGoods;
        private System.Windows.Forms.Button BtnSalesRegister;
    }
}