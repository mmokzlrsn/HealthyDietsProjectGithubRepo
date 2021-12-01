using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M102DietList:IEntity
    {
        public int DietListId { get; set; }
        public int RepeatsId { get; set; }
        public int KcalListId { get; set; }
        public String Note { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
