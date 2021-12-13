using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M100CompanyAddressesDto : IDto
    {
        public int CompanyAddressesId { get; set; }
        public int CompanyInfoId { get; set; }
        public int CityId { get; set; }
    }
}
