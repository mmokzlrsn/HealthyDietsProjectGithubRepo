using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M102RepeatsDto:IDto
    {
        public int RepeatsId { get; set; }
        public int ParentId { get; set; }
        public int RepeatsTypeId { get; set; }
        public int WhoListId { get; set; }
    }
}
