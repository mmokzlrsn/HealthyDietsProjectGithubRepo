using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100AllEmailAddressDto:IDto
    {
        public int AllEmailAddressId { get; set; }
        public int PersonId { get; set; }
    }
}
