using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPOS.Entities.Goods
{
    public class GoodsOrderDetail : EntityBase<Guid>
    {
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal PriceSugestedToSell { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal PriceToSell { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal PricePurchase { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Total { get; set; }

        [ForeignKey("GoodsOrder")]
        public Guid GoodsOrderId { get; set; }
        public virtual GoodsOrder GoodsOrder { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
