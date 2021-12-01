using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M102WhoList:IEntity
    {
        public int WhoListId { get; set; }
        public int EmployeeId { get; set; }
        public int TempEmployeeId { get; set; }// temp employee?
        public int ClientId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime iUDateTime { get; set; }
        public DateTime createDate { get; set; }
        public String guid { get; set; }
    }
}
