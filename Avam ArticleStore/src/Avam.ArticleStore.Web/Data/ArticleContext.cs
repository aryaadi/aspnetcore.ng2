using Microsoft.EntityFrameworkCore;

namespace Avam.ArticleStore.Web.Domain.Data
{
    public class ArticleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./articles.db");
        }
        public DbSet<Article> Tags { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
