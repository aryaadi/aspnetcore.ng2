using System;
using System.Collections.Generic;
using Avam.ArticleStore.Web.Domain;
using System.Linq;

namespace Avam.ArticleStore.Web.Models.Converters
{
    public class TagModelConverter : IModelConverter<Tag, TagModel>
    {
        public IEnumerable<TagModel> ToDto(IEnumerable<Tag> entities)
        {
            IList<TagModel> tags = new List<TagModel>();
            entities.ToList().ForEach(tag => tags.Add(new TagModel(tag)));
            return tags;
        }

        public TagModel ToDto(Tag entity)
        {
            return new TagModel(entity);
        }

        public Tag ToEntity(TagModel dto, Tag entity)
        {
            return dto.GetEntity(entity);
        }
    }
}
