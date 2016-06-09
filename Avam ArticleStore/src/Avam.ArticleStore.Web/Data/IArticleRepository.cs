using Avam.ArticleStore.Web.Domain;
using Avam.ArticleStore.Web.Domain.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Avam.ArticleStore.Web.Data
{
    public interface IArticleRepository : IRepository<Article>
    {

    }

    public class ArticleRepository : GenricRepository<Article>, IArticleRepository
    {
        public ArticleRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
