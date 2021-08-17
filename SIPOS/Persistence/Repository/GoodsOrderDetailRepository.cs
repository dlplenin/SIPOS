using SIPOS.Entities.Goods;
using SIPOS.Persistence.Repository.Contracts;

namespace SIPOS.Persistence.Repository
{
    internal class GoodsOrderDetailRepository : RepositoryBase<GoodsOrderDetail>, IGoodsOrderDetailRepository
    {
        public GoodsOrderDetailRepository(SiposContext repoContext) : base(repoContext)
        {

        }
    }
}
