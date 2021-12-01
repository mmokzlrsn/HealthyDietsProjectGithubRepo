using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100EmailContentSpecifications : IEntity
    {
        public int EmailContentSpecificationsId {get;set;}
        public String Button { get; set; }
        public String Image { get; set; }
        public String Link { get; set; }
        public String Icon { get; set; }
        public String Type { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }



    }
}
