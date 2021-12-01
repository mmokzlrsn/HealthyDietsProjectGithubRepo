using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100AllPhone :IEntity
    {
        public int AllPhoneId { get; set; }
        public int PersonId { get; set; }
        public String Phone { get; set; }
        public String PhoneType { get; set; }
        public int IsDelete { get; set; } // ask these two
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }


    }
}
