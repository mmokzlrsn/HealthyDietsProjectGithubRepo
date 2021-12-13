using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100CitiesDto:IDto
    {
        public int CitiesId { get; set; }
        public int StateId { get; set; }
    }
}
