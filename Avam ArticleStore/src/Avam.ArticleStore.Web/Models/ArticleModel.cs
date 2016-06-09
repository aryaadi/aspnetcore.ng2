using Avam.ArticleStore.Web.Domain;
using System;
using System.Collections.Generic;

namespace Avam.ArticleStore.Web.Models
{
    public class ArticleModel
    {
        #region Public Properties
        public int Id { get;  set; }
        public string Title { get; set; }
        public TagModel PrimaryTag { get; set; }
        public string Description { get; set; }
        public string BriefBody { get; set; }
        public string Source { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime AddedOn { get; set; }
        public string Author { get; set; }
        #endregion

        #region ctors
        public ArticleModel() { }
        public ArticleModel(Article article)
        {
            Id = article.Id;
            Title = article.Description;
            BriefBody = article.BriefBody;
            Description = article.Description;
            PrimaryTag = article.PrimaryTag != null ? new TagModel(article.PrimaryTag) : null;
            Source = article.Source;
            PublishDate = article.PublishDate;
            AddedOn = article.CreatedOn;
            Author = article.Author;
        }
        #endregion

        #region Public Methods
        public Article GetEntity(Article entity)
        {
            entity.Title = Title;
            entity.Description = Description;
            entity.BriefBody = BriefBody;
            entity.PrimaryTag = PrimaryTag.GetEntity(entity.PrimaryTag);
            entity.Source = Source;
            entity.PublishDate = PublishDate;
            entity.Author = Author;
            return entity;
        }
        #endregion

    }
}
