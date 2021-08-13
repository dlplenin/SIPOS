using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPOS.Entities
{
    public class Order : EntityBase<Guid>
    {
        public string Number {  get; set; }
        public DateTime CreationDate {  get; set; } = DateTime.UtcNow;

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal SubTotal { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Total { get; set; }

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
