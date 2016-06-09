using Avam.ArticleStore.Web.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Avam.ArticleStore.Web.Models.Converters
{
    public class ConverterRegisterationHelper
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IModelConverterResolver, ModelConverterResolver>();
            services.AddScoped<IModelConverter<Article, ArticleModel>, ArticleModelConverter>();
            services.AddScoped<IModelConverter<Tag, TagModel>, TagModelConverter>();
        }
    }
}
