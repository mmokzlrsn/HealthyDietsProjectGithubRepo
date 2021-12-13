using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100AddressBookDto:IDto
    {
        public int AddressBookId { get; set; }
        public int CityId { get; set; }
    }
}
