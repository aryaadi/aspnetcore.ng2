using System;
using System.Collections.Generic;

namespace Avam.ArticleStore.Web.Domain
{
    public class Article : AuditableEntityBase
    {
        #region ctor
        public Article()
        {
            //SecondaryTags = new List<Tag>();
        }
        #endregion

        #region Public Properties
        public int Id { get; private set; }
        public string Title { get; set; }
        public int TagId { get; set; }
        public Tag PrimaryTag { get; set; }
        //public virtual List<Tag> SecondaryTags { get; set; }
        public string Description { get; set; }
        public string BriefBody { get; set; }
        public string Source { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        #endregion

        #region Overrides
        protected override bool IsNewObject()
        {
            return Id == 0;
        }
        #endregion
    }
}
