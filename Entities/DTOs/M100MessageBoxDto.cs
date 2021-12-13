using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100MessageBoxDto:IDto
    {
        public int MessageBoxId { get; set; }
        public int IpId { get; set; }
    }
}
