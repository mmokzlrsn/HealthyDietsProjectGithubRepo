using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100Client:IEntity
    {
        public int ClientId { get; set; }
        public int PersonId { get; set; }
        public String CellPhone { get; set; }
        public String Email { get; set; }
        public String RecoveryEmail { get; set; }
        public int Verification { get; set; }
        public String Image { get; set; }
        public String Note { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }

    }
}
