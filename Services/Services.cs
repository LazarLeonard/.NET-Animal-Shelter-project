using Heaven.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Heaven.Services
{
    public class Services<T> : IRepositoryBase<T> where T : class
    {
        protected AdapostContext RepositoryContext { get; set; }

        public Services(AdapostContext repositoryContext) => RepositoryContext = repositoryContext;

        public IQueryable<T> FindAll() => RepositoryContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) => RepositoryContext.Set<T>().Where(expression);

        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);

        public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);

        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);

        public void Save() => this.RepositoryContext.SaveChanges();

        public IQueryable<T> FFindByCondition(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
