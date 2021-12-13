using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100AdminDto:IDto
    {
        public int AdminId { get; set; }
        public int PersonId { get; set; }
    }
}
