using SIPOS.Persistence.Repository.Contracts;
using System.Linq.Expressions;

namespace SIPOS.Persistence.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected SiposContext RepositoryContext { get; set; }
        public RepositoryBase(SiposContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }
        public IQueryable<T> GetAll()
        {
            return this.RepositoryContext.Set<T>();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression);
        }

        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }

        public T GetById(object guid)
        {
            return this.RepositoryContext.Set<T>().Find(guid);
        }
    }
}
