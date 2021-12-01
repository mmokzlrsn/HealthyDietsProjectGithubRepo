using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100ImageContainer:IEntity
    {
        public int ImageContainerId { get; set; }
        public int InsertedByPersonId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int SpecialId { get; set; }
        public String Claims { get; set; }
        public String Title { get; set; }
        public String ImageContainerContent { get; set; }
        public String ImageLink { get; set; }
        public String Type { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
