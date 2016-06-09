using Avam.ArticleStore.Web.Domain;
using Avam.ArticleStore.Web.Domain.Data.Repositories;
using Avam.ArticleStore.Web.Models;
using Avam.ArticleStore.Web.Models.Converters;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Avam.ArticleStore.Web.Controllers
{
    [Route("/api/tags")]
    public class TagController : Controller
    {
        private readonly IRepository<Tag> _repository;
        private readonly IModelConverterResolver _modelConverterResolver;
        public TagController(IRepository<Tag> repository, IModelConverterResolver modelConverterResolver)
        {
            _repository = repository;
            _modelConverterResolver = modelConverterResolver;
        }

        [HttpGet]
        public IActionResult GetAllTags()
        {
            var tags = _repository.FetchAll().ToList();
            return new JsonResult(
                _modelConverterResolver
                .Resolve<Tag, TagModel>()
                .ToDto(tags));
        }
    }
}
