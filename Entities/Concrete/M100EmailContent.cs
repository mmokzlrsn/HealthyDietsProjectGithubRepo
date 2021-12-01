using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100EmailContent:IEntity
    {
        public int EmailContentId { get; set; }
        public String Title { get; set; }
        public String Subject { get; set; }
        public String ContentBody { get; set; }
        public String Type { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }


    }
}
