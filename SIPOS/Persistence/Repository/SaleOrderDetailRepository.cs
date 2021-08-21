using SIPOS.Entities.Sales;
using SIPOS.Persistence.Repository.Contracts;

namespace SIPOS.Persistence.Repository
{
    internal class SaleOrderDetailRepository : RepositoryBase<SaleOrderDetail>, ISaleOrderDetailRepository
    {
        public SaleOrderDetailRepository(SiposContext repoContext) : base(repoContext)
        {

        }
    }
}
