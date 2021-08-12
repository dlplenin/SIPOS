using System.ComponentModel.DataAnnotations;

namespace SIPOS.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password {  get; set; }
    }
}
