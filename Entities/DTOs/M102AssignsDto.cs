using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M102AssignsDto : IDto
    {
        public int AssignsId { get; set; }
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
    }
}
