using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M100TimeZoneDto : IDto
    {
        public int TimeZoneId { get; set; }
        public int CityId { get; set; }
    }
}
