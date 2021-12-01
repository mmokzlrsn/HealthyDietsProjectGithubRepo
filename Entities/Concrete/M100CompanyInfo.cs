using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //didnt created its dataaccess layer.
    public class M100CompanyInfo:IEntity
    {
        public int CompanyInfoId { get; set; }
        public String Name { get; set; }
        public String TaxNumber { get; set; }
        public String BusinessNumber { get; set; }
        public String TaxAddress { get; set; }
        public String TaxType { get; set; }
        public String CodeAndTitle { get; set; }
        public DateTime StartDate { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
