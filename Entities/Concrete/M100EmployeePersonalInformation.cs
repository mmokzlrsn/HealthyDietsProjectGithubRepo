using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100EmployeePersonalInformation:IEntity
    {
        public int EmployeePersonalInformationId { get; set; }
        public int EmployeeId { get; set; }
        public String EducationStatus { get; set; }
        public String ResumeLink { get; set; }
        public String DriverLicence { get; set; }
        public String GovermentId { get; set; }
        public String SerialId { get; set; }
        public DateTime BirthDate { get; set; }
        public String PassportType { get; set; }
        public String CountryCode { get; set; }
        public String PassportNumber { get; set; }
        public String Sex { get; set; }
        public DateTime DateIssues { get; set; } // ??
        public DateTime DateExpiry { get; set; }
        public String IdNumber { get; set; }
        public String IssuedBy { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
