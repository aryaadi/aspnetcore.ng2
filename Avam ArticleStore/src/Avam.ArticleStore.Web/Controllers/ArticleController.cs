using Avam.ArticleStore.Web.Data;
using Avam.ArticleStore.Web.Domain;
using Avam.ArticleStore.Web.Models;
using Avam.ArticleStore.Web.Models.Converters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Linq;

namespace Avam.ArticleStore.Web.Controllers
{
    
    public class ArticleController: Controller
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IModelConverterResolver _modelConverterResolver;
        public ArticleController(IArticleRepository articleRepository, IModelConverterResolver modelConverterResolver)
        {
            _articleRepository = articleRepository;
            _modelConverterResolver = modelConverterResolver;
        }

        [HttpGet]
        [Route("/api/articles")]
        public IActionResult GetAllArticles()
        {
            var articles = _articleRepository.AllIncluding(a => a.PrimaryTag).ToList();
            return new JsonResult(
                _modelConverterResolver
                .Resolve<Article, ArticleModel>()
                .ToDto(articles));
        }

        [HttpPost]
        [Route("/api/articles/save")]
        public IActionResult Post([FromBody] ArticleModel article)
        {
            Article obj = new Article();
            if (article.Id > 0)
            {
                _articleRepository.FindById(article.Id);
            }
            article.GetEntity(obj);
            obj = _articleRepository.Save(article.GetEntity(obj));
            return Ok(obj);
        }
    }
}
