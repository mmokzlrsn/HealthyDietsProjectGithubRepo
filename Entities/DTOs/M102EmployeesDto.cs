using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M102EmployeesDto : IDto
    {
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public int UniversityId { get; set; }
        public int CertificationId { get; set; }
    }
}
