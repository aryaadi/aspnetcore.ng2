using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Avam.ArticleStore.Web.Domain.Data.Repositories
{
    public interface IRepository<T> : IDisposable where T : EntityBase
    {
        IQueryable<T> FetchAll();
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        T FindById<TInput>(TInput id);
        T Save(T entity);
        bool Delete(T entity);
    }
}
