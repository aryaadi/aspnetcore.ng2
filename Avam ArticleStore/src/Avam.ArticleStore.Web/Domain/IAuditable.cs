using System;

namespace Avam.ArticleStore.Web.Domain
{
    public interface IAuditable
    {
        DateTime CreatedOn { get; set; } 
        string CreatedBy { get; set; } 
        DateTime LastModifiedOn { get; set; } 
        string LastModifiedBy { get; set; }
    }
}
