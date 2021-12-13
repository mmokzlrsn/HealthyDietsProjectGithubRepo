using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100MacListDto:IDto
    {
        public int MacListId { get; set; }
        public int IpListId { get; set; }
    }
}
