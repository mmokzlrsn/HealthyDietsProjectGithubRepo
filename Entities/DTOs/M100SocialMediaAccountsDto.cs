using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M100SocialMediaAccountsDto : IDto
    {
        public int SocialMediaAccountsId { get; set; }
        public int AccountType { get; set; }
        public int ResponsibleEmployeeId { get; set; }
        public int RelatedCompanyId { get; set; }
    }
}
