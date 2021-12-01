using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100TimeZone:IEntity
    {
        public int TimeZoneId { get; set; }
        public int CityId { get; set; }
        public String TimeZone { get; set; }
        public String GmtOffSet { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
