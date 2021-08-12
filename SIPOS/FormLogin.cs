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

namespace SIPOS
{
    public partial class FormLogin : Form
    {
        private readonly IRepositoryWrapper repoWrapper;

        public FormLogin(IRepositoryWrapper repoWrapper)
        {
            this.repoWrapper = repoWrapper;
            InitializeComponent();
        }

        private void Txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text.ToLower() == "usuario")
            {
                txt_user.Text = "";
                txt_user.ForeColor = Color.LightGray;
            }
        }

        private void Txt_user_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_user.Text))
            {
                txt_user.Text = "Usuario";
                txt_user.ForeColor = Color.Silver;
            }
        }

        private void Txt_password_Enter(object sender, EventArgs e)
        {
            if (Txt_password.Text.ToLower() == "contraseña")
            {
                Txt_password.Text = "";
                Txt_password.ForeColor = Color.LightGray;
                Txt_password.UseSystemPasswordChar = true;
            }
        }

        private void Txt_password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_password.Text))
            {
                Txt_password.Text = "Contraseña";
                Txt_password.ForeColor = Color.Silver;
                Txt_password.UseSystemPasswordChar = false;
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text.ToLower() != "usuario")
            {
                if (Txt_password.Text.ToLower() != "contraseña")
                {
                    var validUser = true;
                    if(validUser)
                    {
                        MDIParent mDIParent= new();
                        mDIParent.Show();
                        this.Hide();
                    }
                    else
                    {
                        SetErrorMessage("Credenciales incorrectas");
                        ClearPassword();
                    }
                }
                else SetErrorMessage("Ingrese la contraseña");
            }
            else SetErrorMessage("Ingrese el nombre de usuario");
        }

        private void ClearPassword()
        {
            Txt_password.Text = string.Empty;
            Txt_password.Focus();
        }

        private void SetErrorMessage(string message)
        {
            Lbl_mensaje.Text = message;
            Lbl_mensaje.Visible = true;
        }
    }
}
