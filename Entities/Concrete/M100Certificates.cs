using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100Certificates:IEntity
    {
        public int CertificatesId { get; set; }
        public int PersonId { get; set; }
        public String CertificationName { get; set; }
        public String CertificationSerialNumber { get; set; }
        public String CertificationByGets { get; set; }
        public String CertificationImageUrl { get; set; }
        public String CertificationGetDate { get; set; }//date variable?
        public String CertificationExpiryDate { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }

    }
}
