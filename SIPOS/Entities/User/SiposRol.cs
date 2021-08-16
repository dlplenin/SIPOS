namespace SIPOS.Entities.User
{
    public class SiposRol : EntityBase<Guid>
    {
        public string Name {  get; set; }

        public virtual ICollection<SiposUser> SiposUser { get; set; }
    }
}
