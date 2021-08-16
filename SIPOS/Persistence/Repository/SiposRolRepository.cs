using SIPOS.Entities.User;

namespace SIPOS.Persistence.Repository
{
    internal class SiposRolRepository : RepositoryBase<SiposRol>, ISiposRolRepository
    {
        public SiposRolRepository(SiposContext repoContext) : base(repoContext)
        {

        }
    }
}
