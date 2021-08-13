using SIPOS.Entities.User;

namespace SIPOS.Persistence.Repository
{
    public class SiposUserRepository : RepositoryBase<SiposUser>, ISiposUserRepository
    {
        public SiposUserRepository(SiposContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
