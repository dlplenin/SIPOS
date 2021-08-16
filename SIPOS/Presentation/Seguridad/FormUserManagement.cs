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
                    var password = userRow["Password"].EditedFormattedValue.ToString();
                    var rol = userRow["DgvcRol"].Value.ToString();
                    var active = (bool)userRow["Active"].EditedFormattedValue;

                    var a = siposUserService.GetUser(userId);
                    a.UserName = userName;
                    a.Password = password;
                    a.Activo = active;
                    a.SiposRolId = new Guid(rol);

                    //var userToUpdate = new SiposUser
                    //{
                    //    Id = new Guid(userId),
                    //    Activo = active,
                    //    Password = password,
                    //    UserName = userName,
                    //    SiposRolId = new Guid(rol)
                    //};


                    siposUserService.Update(a);
                    repositoryWrapper.Save();
                }
                //else if (e.ColumnIndex == this.colEdit.Index)
                //{
                //    var pallet = this.dataGridView1.Rows[e.RowIndex].DataBoundItem as PrimalPallet;
                //    // etc.
                //}
            }
        }
    }
}
