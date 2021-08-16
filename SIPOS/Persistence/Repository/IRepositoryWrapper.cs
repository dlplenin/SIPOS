namespace SIPOS.Persistence.Repository
{
    public interface IRepositoryWrapper
    {
        ISiposUserRepository UserRepository { get; }
        ISiposRolRepository RolRepository { get; }

        ISupplierRepository SupplierRepository { get; }
        IProductRepository ProductRepository { get; }

        void Save();
    }
}