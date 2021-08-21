using SIPOS.Entities.Sales;
using SIPOS.Persistence.Repository.Contracts;

namespace SIPOS.Persistence.Repository
{
    internal class SaleOrderRepository : RepositoryBase<SaleOrder>, ISaleOrderRepository
    {
        public SaleOrderRepository(SiposContext repoContext) : base(repoContext)
        {

        }
    }
}
