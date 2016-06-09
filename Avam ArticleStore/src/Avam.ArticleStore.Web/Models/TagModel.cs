using Avam.ArticleStore.Web.Domain;

namespace Avam.ArticleStore.Web.Models
{
    public class TagModel
    {
        #region Public Properties
        public int Id { get; private set; }
        public string Name { get; set; }
        #endregion

        #region ctors
        public TagModel() { }
        public TagModel(Tag tag)
        {
            Id = tag.Id;
            Name = tag.Name;
        }
        #endregion

        #region Public Methods
        public Tag GetEntity(Tag entity)
        {
            entity.Name = Name;
            return entity;
        }
        #endregion
    }
}
