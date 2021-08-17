using SIPOS.Entities.User;
using SIPOS.Persistence.Repository.Contracts;

namespace SIPOS.Persistence.Repository
{
    public class SiposUserRepository : RepositoryBase<SiposUser>, ISiposUserRepository
    {
        public SiposUserRepository(SiposContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
