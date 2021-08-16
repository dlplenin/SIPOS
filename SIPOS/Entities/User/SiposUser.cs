using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPOS.Entities.User
{
    public class SiposUser : EntityBase<Guid>
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password {  get; set; }

        [ForeignKey("SiposRol")]
        public Guid SiposRolId { get; set; }
        public virtual SiposRol SiposRol { get; set; }
    }
}
