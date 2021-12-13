using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class M100PersonsAddressesDto:IDto
    {
        public int PersonsAddressesId { get; set; }
        public int AddressBookId { get; set; }
        public int PersonId { get; set; }
    }
}
