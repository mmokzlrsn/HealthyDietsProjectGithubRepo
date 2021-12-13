using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M100DepartmentDto : IDto
    {
        public int DepartmentId { get; set; }
        public int CompanyInfoId { get; set; }
    }
}
