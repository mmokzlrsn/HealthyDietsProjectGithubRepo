using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100MessageBox:IEntity
    {
        public int MessageBoxId { get; set; }
        public int IpId { get; set; }
        public String MessageFrom { get; set; }
        public String MessageTo { get; set; }
        public String MessageSubject { get; set; }
        public String Type { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
