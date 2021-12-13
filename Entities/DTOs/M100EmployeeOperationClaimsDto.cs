using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100EmployeeOperationClaimsDto:IDto
    {
        public int EmployeeOperationClaimsId { get; set; }
        public int PersonId { get; set; }
        public int OperationId { get; set; }
        public int WhoAuthId { get; set; }
    }
}
