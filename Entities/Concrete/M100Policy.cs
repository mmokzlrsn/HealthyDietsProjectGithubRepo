using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100Policy:IEntity
    {
        public int PolicyId { get; set; }
        public int SiteInfoId { get; set; }
        public String Name { get; set; }
        public String PolicyContent { get; set; }
        public String Type { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
