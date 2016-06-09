using Avam.ArticleStore.Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Avam.ArticleStore.Web.Domain.Data.Repositories
{
    public class GenricRepository<T> : IRepository<T> where T : EntityBase
    {

        #region Private Fields
        protected DbContext _dbContext;
        #endregion

        #region ctors
        public GenricRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region IRepository<T>

        public IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public bool Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
            return true;
        }

        public IQueryable<T> FetchAll()
        {
            return _dbContext.Set<T>();
        }

        public T FindById<TInput>(TInput id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public bool Save(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public T Save(T entity)
        {
            if (entity.IsNew) _dbContext.Set<T>().Add(entity);
            if (entity is AuditableEntityBase)
                (entity as AuditableEntityBase).UpdateAuditMembers("bkatoch");
            _dbContext.SaveChanges();
            return entity;
        }
        #endregion

        #region IDisposable Support
        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
