using SIPOS.Persistence.Repository.Contracts;
using SIPOS.Services;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

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
            var user = siposUserService.Login(Global.CurrentUser);
            user.Password = BC.HashPassword(TxtPassword.Text);
            repositoryWrapper.UserRepository.Update(user);
            repositoryWrapper.Save();
        }
    }
}
