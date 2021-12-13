using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100CertificatesDto:IDto
    {
        public int CertificatesId { get; set; }
        public int PersonId { get; set; }
    }
}
