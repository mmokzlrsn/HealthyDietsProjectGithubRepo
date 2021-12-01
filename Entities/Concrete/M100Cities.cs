using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100Cities:IEntity
    {
        public int CitiesId { get; set; }
        public int StateId { get; set; }
        public int TimeZone { get; set; }
        public String Name { get; set; }
        public int IsDelete { get; set; } // not in db
        public int IsActive { get; set; } // not in db
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }

    }
}
