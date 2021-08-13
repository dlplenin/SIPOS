using System.ComponentModel.DataAnnotations;

namespace SIPOS.Entities.User
{
    public class SiposUser : EntityBase<Guid>
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password {  get; set; }

        public virtual ICollection<SiposUserRol> SiposUserRol { get; set; }
    }
}
