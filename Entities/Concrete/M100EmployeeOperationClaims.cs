using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100EmployeeOperationClaims:IEntity
    {
        public int EmployeeOperationClaimsId { get; set; }
        public int PersonId { get; set; }
        public int OperationId { get; set; }
        public int WhoAuthId { get; set; }
        public DateTime AuthDate { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
