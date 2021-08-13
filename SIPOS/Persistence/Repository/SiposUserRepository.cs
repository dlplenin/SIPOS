using SIPOS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPOS.Persistence.Repository
{
    public class SiposUserRepository : RepositoryBase<SiposUser>, ISiposUserRepository
    {
        public SiposUserRepository(SiposContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
