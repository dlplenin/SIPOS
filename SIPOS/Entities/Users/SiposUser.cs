using System.ComponentModel.DataAnnotations;

namespace SIPOS.Entities
{
    public class SiposUser
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password {  get; set; }

        public virtual ICollection<SiposUserRol> SiposUserRol { get; set; }
    }
}
