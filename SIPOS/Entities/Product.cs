using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPOS.Entities
{
    public class Product : EntityBase<Guid>
    {
        [Required]
        public string Name {  get; set; }

        public string Description {  get; set; }

        public string FullDescription
        {
            get { return $"{Name} || {Description}"; }
        }

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
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Stock { get; set; }
    }
}
