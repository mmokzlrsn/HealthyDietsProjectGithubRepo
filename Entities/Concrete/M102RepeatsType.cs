using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M102RepeatsType:IEntity
    {
        public int repeatsTypeId { get; set; }
        public String name { get; set; }
        public int isDelete { get; set; }
        public int isActive { get; set; }
        public DateTime iUDateTime { get; set; }
        public DateTime createDate { get; set; }
        public String guid { get; set; }
    }
}
