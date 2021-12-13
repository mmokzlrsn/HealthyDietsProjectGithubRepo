using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M100ArticleDto : IDto 
    {
        public int ArticleId { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int EditorId { get; set; }
    }
}
