using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Heaven.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AdapostContext AdapostContext { get; set; }

        public RepositoryBase(AdapostContext repositoryContext)
        {
            this.AdapostContext = repositoryContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.AdapostContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.AdapostContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.AdapostContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.AdapostContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.AdapostContext.Set<T>().Remove(entity);
        }

        IQueryable<T> IRepositoryBase<T>.FindAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FFindByCondition(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}