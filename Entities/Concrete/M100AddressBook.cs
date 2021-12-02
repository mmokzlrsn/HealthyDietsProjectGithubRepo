using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100AddressBook : IEntity
    {
        public int AddressBookId { get; set; } 
        public int CityId { get; set; }
        public String AddressField1 { get; set; }
        public String AddressField2 { get; set; }
        public String PostalCode { get; set; }
        public int IsDelete { get; set; } // ask these two
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
