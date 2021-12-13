using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M102ClientDocumentsDto : IDto
    {
        public int ClientDocumentsId { get; set; }
        public int ClientId { get; set; }
    }
}
