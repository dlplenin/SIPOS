using Microsoft.EntityFrameworkCore;
using SIPOS.Persistence;
using SIPOS.Services;
using System.Drawing;
using System.Windows.Forms;

namespace SIPOS
{
    public partial class FormLogin : Form
    {
        private readonly ISiposUserService siposUserService;

        public FormLogin(ISiposUserService siposUserService)
        {
            this.siposUserService = siposUserService;
            InitializeComponent();
        }

        private void Txt_user_Enter(object sender, EventArgs e)
        {
            if (Txt_userName.Text.ToLower() == "usuario")
            {
                Txt_userName.Text = "";
                Txt_userName.ForeColor = Color.LightGray;
            }
        }

        private void Txt_user_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_userName.Text))
            {
                Txt_userName.Text = "Usuario";
                Txt_userName.ForeColor = Color.Silver;
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
            Txt_userName.Text = "diego";
            Txt_password.Text = "diego";

            if (Txt_userName.Text.ToLower() != "usuario")
            {
                if (Txt_password.Text.ToLower() != "contraseña")
                {
                    var validUser = siposUserService.Login(Txt_userName.Text, Txt_password.Text);
                    if(validUser is not null)
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

        private void Txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Btn_login.PerformClick();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            using var context = new SiposContext();
            context.Database.Migrate();
        }
    }
}
