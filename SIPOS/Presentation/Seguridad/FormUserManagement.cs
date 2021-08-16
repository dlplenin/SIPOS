using SIPOS.Services;
using System.Windows.Forms;

namespace SIPOS.Presentation.Seguridad
{
    public partial class FormUserManagement : Form
    {
        private readonly ISiposUserManagementService siposUserService;

        public FormUserManagement(ISiposUserManagementService siposUserService)
        {
            this.siposUserService = siposUserService;
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            CbRol.DataSource = siposUserService.Rol().ToList();
            //CbRol.DataSource = siposUserService.Rol();
            CbRol.DisplayMember = "Name";
            CbRol.ValueMember = "Id";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
