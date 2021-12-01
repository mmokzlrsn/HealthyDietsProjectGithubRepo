using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100SocialMediaAccounts:IEntity 
    {
        public int SocialMediaAccountsId { get; set; }
        public int AccountType { get; set; }
        public int ResponsibleEmployeeId { get; set; }
        public int RelatedCompanyId { get; set; }
        public String Name { get; set; }
        public String Link { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
