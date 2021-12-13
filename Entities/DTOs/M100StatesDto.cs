using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M100StatesDto : IDto
    {
        public int StatesId { get; set; }
        public int CountryId { get; set; }
    }
}
