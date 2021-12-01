using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100MacList:IEntity
    {
        public int MacListId { get; set; }
        public int IpListId { get; set; }
        public String Mac { get; set; } //mac?
        public int IsBlocked { get; set; } //bit in db??
        public String Note { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
