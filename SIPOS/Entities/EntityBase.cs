using System.ComponentModel.DataAnnotations;

namespace SIPOS.Entities
{
    public class EntityBase<T>
    {
        [Key]
        public T Id { get; set; }
        public bool Activo { get; set; } = true;
    }
}
