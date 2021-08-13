namespace SIPOS.Entities
{
    public class SiposRol
    {
        public Guid Id { get; set; }
        public string Name {  get; set; }

        public virtual ICollection<SiposUserRol> SiposUserRol { get; set; }
    }
}
