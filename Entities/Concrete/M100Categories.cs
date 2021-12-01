using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
//MAKE ALL CONCRETES LİKE THİS :IEntity  (IT WILL BE INSIDE OF CORE.ENTITIES)

namespace Entities.Concrete
{
    public class M100Categories:IEntity
    {
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
        public int ParentId { get; set; }
        public String Link { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }

    }
}
