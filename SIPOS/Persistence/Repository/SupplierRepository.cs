using SIPOS.Entities.Goods;

namespace SIPOS.Persistence.Repository
{
    internal class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    {
        public SupplierRepository(SiposContext repoContext) : base(repoContext)
        {

        }
    }
}
