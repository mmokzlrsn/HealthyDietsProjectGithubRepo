using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100DocumentContainerDto:IDto
    {
        public int DocumentContainerId { get; set; }
        public int InsertedByPersonId { get; set; }
        public int CategoryId { get; set; }
        public int SpecialId { get; set; }
    }
}
