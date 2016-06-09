using System.ComponentModel.DataAnnotations.Schema;

namespace Avam.ArticleStore.Web.Domain
{
    public abstract class EntityBase
    {
        [NotMapped]
        public bool IsNew { get { return IsNewObject(); } }
        protected abstract bool IsNewObject();
    }
}
