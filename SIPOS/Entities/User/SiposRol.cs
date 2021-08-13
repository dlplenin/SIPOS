namespace SIPOS.Entities.User
{
    public class SiposRol : EntityBase<Guid>
    {
        public string Name {  get; set; }

        public virtual ICollection<SiposUserRol> SiposUserRol { get; set; }
    }
}
