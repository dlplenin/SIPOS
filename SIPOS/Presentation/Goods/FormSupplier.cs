using SIPOS.Entities.Goods;
using SIPOS.Persistence.Repository.Contracts;
using System.Windows.Forms;

namespace SIPOS.Presentation.Goods
{
    public partial class FormSupplier : Form
    {
        private readonly IRepositoryWrapper repositoryWrapper;

        public FormSupplier(IRepositoryWrapper repositoryWrapper)
        {
            InitializeComponent();
            this.repositoryWrapper = repositoryWrapper;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            DgvSuppliers.Rows.Clear();

            var suppliersInDB = repositoryWrapper.SupplierRepository.GetAll().ToList();

            foreach (var supplier in suppliersInDB)
            {
                DgvSuppliers.Rows.Add(supplier.Id, supplier.Name, supplier.Identification, supplier.Phone, supplier.Email, supplier.Activo);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var newSupplier = new Supplier
            {
                Name = TxtName.Text,
                Identification = TxtIdentificaion.Text,
                Phone = TxtPhone.Text,
                Email = TxtEmail.Text
            };
            repositoryWrapper.SupplierRepository.Create(newSupplier);
            repositoryWrapper.Save();

            LoadSuppliers();
        }

        private void DgvSuppliers_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DgvSuppliers.Cursor = Cursors.Default;
            if (e.ColumnIndex == ColSupplierUpdate.Index)
                DgvSuppliers.Cursor = Cursors.Hand;
        }

        private void DgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == this.ColSupplierUpdate.Index)
                {
                    var userRow = this.DgvSuppliers.Rows[e.RowIndex].Cells;

                    var userId = userRow[ColSupplierId.Name].Value.ToString();
                    var name = userRow[ColSupplierName.Name].EditedFormattedValue.ToString();
                    var identification = userRow[ColSupplierIdentification.Name].Value.ToString();
                    var phone = userRow[ColSupplierPhone.Name].Value.ToString();
                    var email = userRow[ColSupplierEmail.Name].Value.ToString();
                    var active = (bool)userRow["Active"].Value;

                    var supplierToUpdate = repositoryWrapper.SupplierRepository.GetById(new Guid(userId));
                    supplierToUpdate.Name = name;
                    supplierToUpdate.Identification = identification;
                    supplierToUpdate.Phone = phone;
                    supplierToUpdate.Email = email;
                    supplierToUpdate.Activo = active;

                    repositoryWrapper.SupplierRepository.Update(supplierToUpdate);
                    repositoryWrapper.Save();
                }
            }
        }
    }
}
