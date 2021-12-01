using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //WHY M102?
    public class M102Employees :IEntity  
    {
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public int UniversityId { get; set; }
        public int CertificationId { get; set; }
        public String DiplomaNo { get; set; }
        public String DiplomaImageUrl { get; set; }
        public String WorkPlace { get; set; }
        public String WorkPlaceAdresss { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
