using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M100CategoriesDto : IDto
    {
        public int CategoryId { get; set; }
        public int ParentId { get; set; }
    }
}
