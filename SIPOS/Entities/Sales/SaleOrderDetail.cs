﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPOS.Entities.Sales
{
    public class SaleOrderDetail : EntityBase<Guid>
    {
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal PriceToSell { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Total { get; set; }

        [ForeignKey("SaleOrder")]
        public Guid SaleOrderId { get; set; }
        public virtual SaleOrder SaleOrder { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
