using System.Collections.Generic;

namespace Avam.ArticleStore.Web.Models.Converters
{
    public interface IModelConverter<TEntity, TDto>
    {
        TDto ToDto(TEntity entity);
        IEnumerable<TDto> ToDto(IEnumerable<TEntity> entities);
        TEntity ToEntity(TDto dto, TEntity entity);
        //IEnumerable<TEntity> ToEntity(IEnumerable<TDto> dtos);
    }
}
