using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100EmployeePersonalInformationDto:IDto
    {
        public int EmployeePersonalInformationId { get; set; }
        public int EmployeeId { get; set; }
        public String GovermentId { get; set; }
    }
}
