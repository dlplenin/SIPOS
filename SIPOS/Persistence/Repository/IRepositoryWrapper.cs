namespace SIPOS.Persistence.Repository
{
    public interface IRepositoryWrapper
    {
        ISiposUserRepository UserRepository { get; }
        ISiposRolRepository RolRepository { get; }

        void Save();
    }
}