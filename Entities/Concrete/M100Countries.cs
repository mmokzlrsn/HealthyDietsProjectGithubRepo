using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //
    public class M100Countries:IEntity
    {
        public int CountriesId { get; set; }
        public String Name { get; set; }
        public String Code { get; set; }
        public String PhoneCode { get; set; }
        public String Currency { get; set; }

        //is delete, is active , yok SHOW
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
