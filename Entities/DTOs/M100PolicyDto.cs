using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M100PolicyDto : IDto
    {
        public int PolicyId { get; set; }
        public int SiteInfoId { get; set; }
    }
}
