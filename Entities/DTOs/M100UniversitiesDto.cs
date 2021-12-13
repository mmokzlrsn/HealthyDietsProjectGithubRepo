using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M100UniversitiesDto : IDto
    {
        public int UniversitiesId { get; set; }
        public int CityId { get; set; }
    }
}
