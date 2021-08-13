using Microsoft.EntityFrameworkCore;
using SIPOS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPOS.Persistence
{
    public class RepositoryContext : DbContext
    {
        //public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SIPOS;Integrated Security=True");
        }

        public DbSet<SiposUser> SiposUser { get; set; }
    }
}
