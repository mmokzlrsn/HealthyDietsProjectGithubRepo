using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100EmailControl : IEntity
    {
        public int EmailControlId {get;set;}
        public String Email { get; set; }
        public String Password { get; set; }
        public String Port { get; set; }
        public String Host { get; set; }
        public String EmailCategory { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }


    }
}
