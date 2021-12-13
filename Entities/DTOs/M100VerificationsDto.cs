using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M100VerificationsDto : IDto
    {
        public int VerificationsId { get; set; }
        public int PersonId { get; set; }
    }
}
