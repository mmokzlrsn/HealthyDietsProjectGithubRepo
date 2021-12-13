using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100ExceptionLogsDto:IDto
    {
        public int ExceptionLogsId { get; set; }
        public int WhoAuthId { get; set; }
    }
}
