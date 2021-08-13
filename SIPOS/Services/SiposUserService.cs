using SIPOS.Entities;
using SIPOS.Persistence.Repository;

namespace SIPOS.Services
{
    public class SiposUserService : ISiposUserService
    {
        private readonly IRepositoryWrapper repoWrapper;

        public SiposUserService(IRepositoryWrapper repoWrapper)
        {
            this.repoWrapper = repoWrapper;
        }

        public SiposUser Login(string user, string password)
        {
            return repoWrapper.UserRepository
                .FindByCondition(x => x.UserName == user && x.Password == password)
                .FirstOrDefault();
        }
    }
}
