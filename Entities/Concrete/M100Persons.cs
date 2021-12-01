using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100Persons:IEntity
    {
        public int PersonsId { get; set; }
        public String IdentityNumber { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }


    }
}
