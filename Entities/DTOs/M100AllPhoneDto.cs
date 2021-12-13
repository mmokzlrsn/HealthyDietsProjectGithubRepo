using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100AllPhoneDto:IDto
    {
        public int AllPhoneId { get; set; }
        public int PersonId { get; set; }
    }
}
