using SIPOS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPOS.Persistence.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly RepositoryContext repoContext;
        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            repoContext = repositoryContext;
        }

        private IUserRepository _userReposository;

        public IUserRepository UserRepository
        {
            get
            {
                if (_userReposository == null)
                {
                    _userReposository = new UserRepository(repoContext);
                }
                return _userReposository;
            }
        }

        public void Save()
        {
            repoContext.SaveChanges();
        }
    }
}
