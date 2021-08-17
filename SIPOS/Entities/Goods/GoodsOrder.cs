using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPOS.Entities.Goods
{
    public class GoodsOrder : EntityBase<Guid>
    {
        public string Invoice { get; set; }
        public DateTime ModificationDate { get; set; } = DateTime.Now;
        public DateTime InvoiceDate { get; set; }

        [MaxLength(5000)]
        public string Notes { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Total { get; set; }

        public virtual ICollection<GoodsOrderDetail> GoodsOrderDetail { get; set; }

        [ForeignKey("Suplier")]
        public Guid SuplierId { get; set; }
        public virtual Supplier Suplier { get; set; }
    }
}
