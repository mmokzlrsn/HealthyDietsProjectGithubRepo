using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M102Repeats:IEntity
    {
        public int repeatsId { get; set; }
        public int parentId { get; set; }
        public int repeatsTypeId { get; set; }
        public int whoListId { get; set; }
        public int numberofDay { get; set; }
        public int isDelete { get; set; }
        public int isActive { get; set; }
        public DateTime iUDateTime { get; set; }
        public DateTime createDate { get; set; }
        public String guid { get; set; }
    }
}
