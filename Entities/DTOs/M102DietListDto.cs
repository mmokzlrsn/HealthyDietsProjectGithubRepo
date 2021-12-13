using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M102DietListDto : IDto
    {
        public int DietListId { get; set; }
        public int RepeatsId { get; set; }
        public int KcalListId { get; set; }
    }
}
