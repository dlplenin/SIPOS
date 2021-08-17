using SIPOS.Entities.Goods;
using SIPOS.Persistence.Repository.Contracts;

namespace SIPOS.Persistence.Repository
{
    internal class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    {
        public SupplierRepository(SiposContext repoContext) : base(repoContext)
        {

        }
    }
}
