using SIPOS.Entities.User;
using SIPOS.Persistence.Repository.Contracts;

namespace SIPOS.Services
{
    public class SiposUserManagementService : ISiposUserManagementService
    {
        private readonly IRepositoryWrapper repoWrapper;

        public SiposUserManagementService(IRepositoryWrapper repoWrapper)
        {
            this.repoWrapper = repoWrapper;
        }

        public SiposUser Login(string user)
        {
            return repoWrapper.UserRepository
                .FindByCondition(x => x.UserName == user)
                .FirstOrDefault();
        }
    }
}
