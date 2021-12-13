using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M102WhoListDto : IDto
    {
        public int WhoListId { get; set; }
        public int EmployeeId { get; set; }
        public int TempEmployeeId { get; set; }
        public int ClientId { get; set; }
    }
}
