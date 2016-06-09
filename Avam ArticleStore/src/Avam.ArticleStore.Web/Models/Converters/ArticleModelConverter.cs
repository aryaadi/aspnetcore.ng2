using Avam.ArticleStore.Web.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avam.ArticleStore.Web.Models.Converters
{
    public class ArticleModelConverter : IModelConverter<Article, ArticleModel>
    {
        #region
        public ArticleModel ToDto(Article entity)
        {
            return new ArticleModel(entity);
        }
        public IEnumerable<ArticleModel> ToDto(IEnumerable<Article> entities)
        {
            IList<ArticleModel> dtos = new List<ArticleModel>();
            entities.ToList().ForEach((article) => { dtos.Add(new ArticleModel(article)); });
            return dtos;
        }
        public Article ToEntity(ArticleModel dto, Article entity)
        {
            return dto.GetEntity(entity);
        }
        #endregion
    }
}
