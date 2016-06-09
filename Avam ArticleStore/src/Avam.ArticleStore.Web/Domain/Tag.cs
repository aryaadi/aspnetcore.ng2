using System;
namespace Avam.ArticleStore.Web.Domain
{
    public class Tag : AuditableEntityBase
    {
        #region Public Properties
        public int Id { get; private set; }
        public string Name { get; set; }
        #endregion

        #region Overrides
        protected override bool IsNewObject()
        {
            return Id == 0;
        }
        #endregion
    }
}
