using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPOS.Entities
{
    public class SiposUserRol
    {
        [ForeignKey("SiposUser")]
        public Guid SiposUserId { get; set; }
        public virtual SiposUser SiposUser { get; set; }

        [ForeignKey("SiposRol")]
        public Guid SiposRolId { get; set; }
        public virtual SiposRol SiposRol { get; set; }
    }
}
