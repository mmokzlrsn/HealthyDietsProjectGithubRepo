using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100DepartmentDetails : IEntity
    {
        public int DepartmentDetailsId { get; set; }
        public int DepartmentId { get; set; }
        public int ByCharge { get; set; }
        public String Email { get; set; }
        public String Extension { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }




    }
}
