namespace SIPOS.Persistence.Repository.Contracts
{
    public interface IRepositoryWrapper
    {
        ISiposUserRepository UserRepository { get; }
        ISiposRolRepository RolRepository { get; }

        ISupplierRepository SupplierRepository { get; }
        IProductRepository ProductRepository { get; }
        IGoodsOrderRepository GoodsOrderRepository { get; }
        IGoodsOrderDetailRepository GoodsOrderDetailRepository { get; }
        ISaleOrderRepository SaleOrderRepository { get; }
        ISaleOrderDetailRepository SaleOrderDetailRepository { get; }

        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        void Save();
    }
}
