using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100Admin:IEntity
    {
        public int AdminId { get; set; }
        public int PersonId { get; set; }
        public String Password { get; set; }
        public int IsDelete { get; set; } 
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
