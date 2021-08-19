using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPOS.Entities.Sales
{
    public class SaleOrder : EntityBase<Guid>
    {
        public string Invoice {  get; set; }
        public DateTime ModificationDate {  get; set; } = DateTime.Now;
        public DateTime InvoiceDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Total { get; set; }

        public virtual ICollection<SaleOrderDetail> OrderDetail { get; set; }
    }
}
