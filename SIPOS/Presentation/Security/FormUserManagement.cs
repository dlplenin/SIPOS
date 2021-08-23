using SIPOS.Entities.User;
using SIPOS.Persistence.Repository.Contracts;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace SIPOS.Presentation.Security
{
    public partial class FormUserManagement : Form
    {
        private readonly IRepositoryWrapper repositoryWrapper;

        public FormUserManagement(IRepositoryWrapper repositoryWrapper)
        {
            this.repositoryWrapper = repositoryWrapper;
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            var rols = repositoryWrapper.RolRepository.GetAll().ToList();

            CbRol.DataSource = rols;
            CbRol.DisplayMember = "Name";
            CbRol.ValueMember = "Id";

            LoadUsers();
        }

        private void LoadUsers()
        {
            var rols = repositoryWrapper.RolRepository.GetAll().ToList();
            DgvcRol.DataSource = rols;
            DgvcRol.DisplayMember = "Name";
            DgvcRol.ValueMember = "Id";

            var usersInDB = repositoryWrapper.UserRepository.GetAll().ToList();
            DgvUsuarios.Rows.Clear();
            foreach (var user in usersInDB)
            {
                DgvUsuarios.Rows.Add(user.Id, user.UserName, user.Password, user.SiposRol.Id, user.Activo);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (AnyMissingRequiredTextBox())
                return;

            var newUser = new SiposUser
            {
                UserName = TxtUserName.Text,
                Password = BC.HashPassword(TxtPassword.Text),
                SiposRolId = new Guid(CbRol.SelectedValue.ToString())
            };
            repositoryWrapper.UserRepository.Create(newUser);
            repositoryWrapper.Save();

            ClearTextBox();

            LoadUsers();
        }

        private void ClearTextBox()
        {
            var boxesToClear = Controls.OfType<TextBox>();
            foreach (var box in boxesToClear)
            {
                box.Text = string.Empty;
            }
        }

        private bool AnyMissingRequiredTextBox()
        {
            errorProvider.Clear();
            var requiredBoxes = Controls.OfType<TextBox>().Where(x => (x.Tag ?? "").ToString() == "required");
            var anyMissingRequired = false;
            foreach (var box in requiredBoxes)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    anyMissingRequired = true;
                    errorProvider.SetError(box, "Es un campo requerido");
                }
            }

            return anyMissingRequired;
        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == this.DgviUpdate.Index)
                {
                    var userRow = this.DgvUsuarios.Rows[e.RowIndex].Cells;

                    var userId = userRow["UserId"].Value.ToString();
                    var userName = userRow["UserName"].EditedFormattedValue.ToString();
                    var password = userRow["Password"].Value.ToString();
                    var rol = userRow["DgvcRol"].Value.ToString();
                    var active = (bool)userRow["Active"].EditedFormattedValue;

                    var userToUpdate = repositoryWrapper.UserRepository.GetById(new Guid(userId));
                    userToUpdate.UserName = userName;
                    userToUpdate.Password = BC.HashPassword(password);
                    userToUpdate.Activo = active;
                    userToUpdate.SiposRolId = new Guid(rol);

                    repositoryWrapper.UserRepository.Update(userToUpdate);
                    repositoryWrapper.Save();

                    MessageBox.Show("El registro se actualizó correctamente.", "Actualización");
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

        private void DgvUsuarios_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DgvUsuarios.Cursor = Cursors.Default;
            
            if (e.ColumnIndex == DgviUpdate.Index)
            {
                DgvUsuarios.Cursor = Cursors.Hand;
            }
        }
    }
}
