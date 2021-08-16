using Microsoft.EntityFrameworkCore;
using SIPOS.Entities.User;
using SIPOS.Persistence.Repository;
using System.Linq;

namespace SIPOS.Services
{
    public class SiposUserManagementService : ISiposUserManagementService
    {
        private readonly IRepositoryWrapper repoWrapper;

        public SiposUserManagementService(IRepositoryWrapper repoWrapper)
        {
            this.repoWrapper = repoWrapper;
        }

        public IQueryable<SiposUser> GetAllUsers()
        {
            return repoWrapper.UserRepository
                .FindAll()
                .Include(x => x.SiposRol);
        }

        public SiposUser GetUser(string id)
        {
            return repoWrapper.UserRepository
                .FindByCondition( x => x.Id.ToString() == id)
                .FirstOrDefault();
        }

        public SiposUser Login(string user, string password)
        {
            return repoWrapper.UserRepository
                .FindByCondition(x => x.UserName == user && x.Password == password)
                .FirstOrDefault();
        }

        public IQueryable<SiposRol> Rol()
        {
            return repoWrapper.RolRepository
                .FindAll();
        }

        public void Update(SiposUser userToUpdate)
        {
            repoWrapper.UserRepository
                .Update(userToUpdate);
        }
    }
}
