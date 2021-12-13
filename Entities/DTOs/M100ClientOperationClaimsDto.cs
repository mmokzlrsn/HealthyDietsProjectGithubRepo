using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M100ClientOperationClaimsDto : IDto
    {
        public int ClientOperationClaimsIp { get; set; }
        public int PersonId { get; set; }
        public int OperationId { get; set; }
        public int WhoAuthId { get; set; }
    }
}
