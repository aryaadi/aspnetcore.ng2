using System;

namespace Avam.ArticleStore.Web.Models.Converters
{
    public interface IModelConverterResolver
    {
        IModelConverter<TEntity, TDto> Resolve<TEntity, TDto>();
    }

    public class ModelConverterResolver : IModelConverterResolver
    {
        private IServiceProvider _provider;

        public ModelConverterResolver(IServiceProvider provider)
        {
            _provider = provider;
        }

        public IModelConverter<TEntity, TDto> Resolve<TEntity, TDto>()
        {
            return _provider
                        .GetService(typeof(IModelConverter<TEntity, TDto>)) 
                        as IModelConverter<TEntity, TDto>;
        }
    }
}
