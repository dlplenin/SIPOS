using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPOS.Entities
{
    public class Product
    {
        [Key]
        public Guid Id {  get; set; }

        [Required]
        public string Name {  get; set; }

        public string Description {  get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal PriceSell { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal PricePurchase { get; set; }
    }
}
