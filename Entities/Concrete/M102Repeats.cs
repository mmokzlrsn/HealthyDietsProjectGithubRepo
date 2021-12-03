using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M102Repeats:IEntity
    {
        public int RepeatsId { get; set; }
        public int ParentId { get; set; }
        public int RepeatsTypeId { get; set; }
        public int WhoListId { get; set; }
        public int NumberofDay { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
