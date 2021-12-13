using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100EmployeeDto:IDto
    {
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public int EmployeePersonelInfoId { get; set; } // Info Id
    }
}
