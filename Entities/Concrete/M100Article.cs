using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100Article:IEntity
    {
        public int ArticleId { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int EditorId { get; set; } 
        public String Title { get; set; }
        public String ArticleContent { get; set; }
        public DateTime PublishDate { get; set; }
        public String Tags { get; set; }
        public String MainImage { get; set; }
        public String Url { get; set; }
        public String VideoUrl { get; set; }
        public String ArticleStatus { get; set; }
        public int IsDelete { get; set; } 
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }



    }
}
