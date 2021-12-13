using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100ImageContainerDto:IDto
    {
        public int ImageContainerId { get; set; }
        public int InsertedByPersonId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int SpecialId { get; set; }
    }
}
