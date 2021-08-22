using SIPOS.Persistence.Repository.Contracts;
using SIPOS.Services;
using System.Windows.Forms;

namespace SIPOS.Presentation.Security
{
    public partial class FormChangeMyPassword : Form
    {
        private readonly ISiposUserManagementService siposUserService;
        private readonly IRepositoryWrapper repositoryWrapper;

        public FormChangeMyPassword(ISiposUserManagementService siposUserService, IRepositoryWrapper repositoryWrapper)
        {
            InitializeComponent();
            this.siposUserService = siposUserService;
            this.repositoryWrapper = repositoryWrapper;
        }

        private void FormChangeMyPassword_Load(object sender, EventArgs e)
        {
            TxtUserName.Text = Global.CurrentUser;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            var user = siposUserService.Login(Global.CurrentUser, Global.CurrentPassword);
            user.Password = TxtPassword.Text;
            repositoryWrapper.UserRepository.Update(user);
            repositoryWrapper.Save();
        }
    }
}
