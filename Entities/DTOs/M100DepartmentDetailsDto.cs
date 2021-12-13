using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M100DepartmentDetailsDto : IDto
    {
        public int DepartmentDetailsId { get; set; }
        public int DepartmentId { get; set; }
    }
}
