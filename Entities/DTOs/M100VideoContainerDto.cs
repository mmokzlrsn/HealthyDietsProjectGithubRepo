using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M100VideoContainerDto : IDto
    {
        public int VideoContainerId { get; set; }
        public int InsertedByPersonId { get; set; }
        public int CategoryId { get; set; }
    }
}
