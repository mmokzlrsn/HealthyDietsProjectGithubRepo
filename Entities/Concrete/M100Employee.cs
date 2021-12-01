using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100Employee:IEntity
    {
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public int EmployeePersonelInfoId { get; set; } // Info Id
        public int WorkPhone { get; set; } // int ?
        public String CellPhone { get; set; }
        public String EmergencyPhone { get; set; }
        public String Title { get; set; }
        public int Verification { get; set; }
        public String Image { get; set; }//ask this image string?
        // bit - path 
        public String Note { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }


    }
}
