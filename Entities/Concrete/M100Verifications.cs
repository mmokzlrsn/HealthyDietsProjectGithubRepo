using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100Verifications:IEntity
    {
        public int VerificationsId { get; set; }
        public int PersonId { get; set; }
        public String Claims { get; set; }
        public String Code { get; set; }
        public String ByEmail { get; set; } //in db type was bit??
        public String ByPhone { get; set; } //in db type was bit??
        public String Note { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
