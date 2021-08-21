using SIPOS.Persistence.Repository.Contracts;

namespace SIPOS.Persistence.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly SiposContext repoContext;
        public RepositoryWrapper(SiposContext repositoryContext)
        {
            repoContext = repositoryContext;
        }

        private ISiposUserRepository _userReposository;
        private ISiposRolRepository _rolRepository;

        private ISupplierRepository _supplierRepository;
        private IProductRepository productRepository;
        private IGoodsOrderRepository goodsOrderRepository;
        private IGoodsOrderDetailRepository goodsOrderDetailRepository;

        private ISaleOrderRepository saleOrderRepository;
        private ISaleOrderDetailRepository saleOrderDetailRepository;

        public ISiposUserRepository UserRepository
        {
            get
            {
                if (_userReposository == null)
                {
                    _userReposository = new SiposUserRepository(repoContext);
                }
                return _userReposository;
            }
        }

        public ISiposRolRepository RolRepository
        {
            get
            {
                if (_rolRepository == null)
                {
                    _rolRepository = new SiposRolRepository(repoContext);
                }
                return _rolRepository;
            }
        }

        public ISupplierRepository SupplierRepository
        {
            get
            {
                if (_supplierRepository == null)
                {
                    _supplierRepository = new SupplierRepository(repoContext);
                }
                return _supplierRepository;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new ProductRepository(repoContext);
                }
                return productRepository;
            }
        }

        public IGoodsOrderRepository GoodsOrderRepository
        {
            get
            {
                if (goodsOrderRepository == null)
                {
                    goodsOrderRepository = new GoodsOrderRepository(repoContext);
                }
                return goodsOrderRepository;
            }
        }

        public IGoodsOrderDetailRepository GoodsOrderDetailRepository
        {
            get
            {
                if (goodsOrderDetailRepository == null)
                {
                    goodsOrderDetailRepository = new GoodsOrderDetailRepository(repoContext);
                }
                return goodsOrderDetailRepository;
            }
        }

        public ISaleOrderRepository SaleOrderRepository
        {
            get
            {
                if (saleOrderRepository == null)
                {
                    saleOrderRepository = new SaleOrderRepository(repoContext);
                }
                return saleOrderRepository;
            }
        }

        public ISaleOrderDetailRepository SaleOrderDetailRepository
        {
            get
            {
                if (saleOrderDetailRepository == null)
                {
                    saleOrderDetailRepository = new SaleOrderDetailRepository(repoContext);
                }
                return saleOrderDetailRepository;
            }
        }

        public void Save()
        {
            repoContext.SaveChanges();
        }

        public void BeginTransaction()
        {
            repoContext.BeginTransaction();
        }

        public void CommitTransaction()
        {
            repoContext.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            repoContext.RollbackTransaction();
        }
    }
}
