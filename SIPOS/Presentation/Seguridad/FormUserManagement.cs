using SIPOS.Entities.User;
using SIPOS.Persistence.Repository;
using SIPOS.Services;
using System.Windows.Forms;

namespace SIPOS.Presentation.Seguridad
{
    public partial class FormUserManagement : Form
    {
        private readonly ISiposUserManagementService siposUserService;
        private readonly IRepositoryWrapper repositoryWrapper;

        public FormUserManagement(ISiposUserManagementService siposUserService, IRepositoryWrapper repositoryWrapper)
        {
            this.siposUserService = siposUserService;
            this.repositoryWrapper = repositoryWrapper;
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            var rols = siposUserService.Rol().ToList();
            CbRol.DataSource = rols;
            CbRol.DisplayMember = "Name";
            CbRol.ValueMember = "Id";

            DgvcRol.DataSource = rols;
            DgvcRol.DisplayMember = "Name";
            DgvcRol.ValueMember = "Id";

            foreach (var user in siposUserService.GetAllUsers().ToList())
            {
                DgvUsuarios.Rows.Add(user.Id, user.UserName, user.Password, user.SiposRol.Id, user.Activo);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == this.DgvbUpdate.Index)
                {
                    var userRow = this.DgvUsuarios.Rows[e.RowIndex].Cells;

                    var userId = userRow["UserId"].Value.ToString();
                    var userName = userRow["UserName"].EditedFormattedValue.ToString();
                    var password = userRow["Password"].Value.ToString();
                    var rol = userRow["DgvcRol"].Value.ToString();
                    var active = (bool)userRow["Active"].EditedFormattedValue;

                    var userToUpdate = siposUserService.GetUser(userId);
                    userToUpdate.UserName = userName;
                    userToUpdate.Password = password;
                    userToUpdate.Activo = active;
                    userToUpdate.SiposRolId = new Guid(rol);


                    siposUserService.Update(userToUpdate);
                    repositoryWrapper.Save();
                }
            }
        }

        private void DgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == this.Password.Index && e.Value != null)
            {
                DgvUsuarios.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var newUser = new SiposUser
            {
                UserName = TxtUserName.Text,
                Password = TxtPassword.Text,
                SiposRolId = new Guid(CbRol.SelectedValue.ToString())
            };
            repositoryWrapper.UserRepository.Create(newUser);
            repositoryWrapper.Save();
        }
    }
}
