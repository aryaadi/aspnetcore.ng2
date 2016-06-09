using System;

namespace Avam.ArticleStore.Web.Domain
{
    public abstract class AuditableEntityBase : EntityBase, IAuditable
    {
        #region IAuditable Memebers
 
        public string CreatedBy { get; set; } 
        public DateTime CreatedOn { get; set; } 
        public string LastModifiedBy { get; set; } 
        public DateTime LastModifiedOn { get; set; } 
        #endregion 

        #region Public Methods
 
        public void UpdateAuditMembers(string userName)
        { 
            CreatedBy = CreatedBy ?? userName; 
            LastModifiedBy = userName; 
            CreatedOn = CreatedOn == DateTime.MinValue? DateTime.UtcNow : CreatedOn; 
            LastModifiedOn = DateTime.UtcNow; 
        } 
        #endregion 
    }
}
