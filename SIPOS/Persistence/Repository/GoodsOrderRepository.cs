using SIPOS.Entities.Goods;
using SIPOS.Persistence.Repository.Contracts;

namespace SIPOS.Persistence.Repository
{
    internal class GoodsOrderRepository : RepositoryBase<GoodsOrder>, IGoodsOrderRepository
    {
        public GoodsOrderRepository(SiposContext repoContext) : base(repoContext)
        {

        }
    }
}
