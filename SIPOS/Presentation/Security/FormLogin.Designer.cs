
namespace SIPOS.Presentation.Security
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_login = new System.Windows.Forms.Label();
            this.Txt_userName = new System.Windows.Forms.TextBox();
            this.Txt_password = new System.Windows.Forms.TextBox();
            this.Btn_login = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 330);
            this.panel1.TabIndex = 0;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(395, 41);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(219, 32);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "INICIO DE SESIÓN";
            // 
            // Txt_userName
            // 
            this.Txt_userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Txt_userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_userName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_userName.ForeColor = System.Drawing.Color.Silver;
            this.Txt_userName.Location = new System.Drawing.Point(297, 105);
            this.Txt_userName.Name = "Txt_userName";
            this.Txt_userName.Size = new System.Drawing.Size(408, 24);
            this.Txt_userName.TabIndex = 2;
            this.Txt_userName.Text = "Usuario";
            this.Txt_userName.Enter += new System.EventHandler(this.Txt_user_Enter);
            this.Txt_userName.Leave += new System.EventHandler(this.Txt_user_Leave);
            // 
            // Txt_password
            // 
            this.Txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_password.ForeColor = System.Drawing.Color.Silver;
            this.Txt_password.Location = new System.Drawing.Point(297, 171);
            this.Txt_password.Name = "Txt_password";
            this.Txt_password.Size = new System.Drawing.Size(408, 24);
            this.Txt_password.TabIndex = 3;
            this.Txt_password.Text = "Contraseña";
            this.Txt_password.Enter += new System.EventHandler(this.Txt_password_Enter);
            this.Txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_password_KeyDown);
            this.Txt_password.Leave += new System.EventHandler(this.Txt_password_Leave);
            // 
            // Btn_login
            // 
            this.Btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.Btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.Btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.Btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_login.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_login.Location = new System.Drawing.Point(297, 253);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(408, 40);
            this.Btn_login.TabIndex = 4;
            this.Btn_login.Text = "ACCEDER";
            this.Btn_login.UseVisualStyleBackColor = false;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_cerrar.Location = new System.Drawing.Point(743, 12);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(25, 28);
            this.Btn_cerrar.TabIndex = 5;
            this.Btn_cerrar.Text = "X";
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(297, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 2);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(296, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 2);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Lbl_mensaje
            // 
            this.Lbl_mensaje.AutoSize = true;
            this.Lbl_mensaje.ForeColor = System.Drawing.Color.LightCoral;
            this.Lbl_mensaje.Location = new System.Drawing.Point(299, 216);
            this.Lbl_mensaje.Name = "Lbl_mensaje";
            this.Lbl_mensaje.Size = new System.Drawing.Size(0, 20);
            this.Lbl_mensaje.TabIndex = 8;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.Lbl_mensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_cerrar);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.Txt_password);
            this.Controls.Add(this.Txt_userName);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox Txt_userName;
        private System.Windows.Forms.TextBox Txt_password;
        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_mensaje;
    }
}

