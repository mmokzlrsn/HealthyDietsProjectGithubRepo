using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100IpList:IEntity
    {
        public int IpListId { get; set; }
        public int PersonId { get; set; }
        public String Ip { get; set; }
        public short IsBlocked { get; set; } //type bit?
        public String Note { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
