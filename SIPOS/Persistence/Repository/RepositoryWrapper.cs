﻿using SIPOS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Save()
        {
            repoContext.SaveChanges();
        }
    }
}
