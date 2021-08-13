using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPOS.Entities
{
    public class Product : EntityBase<Guid>
    {
        [Required]
        public string Name {  get; set; }

        public string Description {  get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal SugestedPriceToSell { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal PriceSell { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal PricePurchase { get; set; }
    }
}
