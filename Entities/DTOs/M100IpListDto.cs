using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100IpListDto:IDto
    {
        public int IpListId { get; set; }
        public int PersonId { get; set; }
    }
}
