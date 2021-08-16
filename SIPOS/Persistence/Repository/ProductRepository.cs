using SIPOS.Entities;

namespace SIPOS.Persistence.Repository
{
    internal class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(SiposContext repoContext) : base(repoContext)
        {

        }
    }
}
