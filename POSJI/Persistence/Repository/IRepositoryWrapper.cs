namespace SIPOS.Persistence.Repository
{
    public interface IRepositoryWrapper
    {
        IUserRepository UserRepository { get; }
        void Save();
    }
}