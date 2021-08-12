namespace SIPOS.Persistence.Repository
{
    public interface IRepositoryWrapper
    {
        ISiposUserRepository UserRepository { get; }
        void Save();
    }
}