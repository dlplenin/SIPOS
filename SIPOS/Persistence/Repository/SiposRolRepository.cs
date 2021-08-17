using SIPOS.Entities.User;
using SIPOS.Persistence.Repository.Contracts;

namespace SIPOS.Persistence.Repository
{
    internal class SiposRolRepository : RepositoryBase<SiposRol>, ISiposRolRepository
    {
        public SiposRolRepository(SiposContext repoContext) : base(repoContext)
        {

        }
    }
}
