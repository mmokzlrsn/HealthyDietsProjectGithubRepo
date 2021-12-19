using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100CertificatesDal : EfEntityRepositoryBase<M100Certificates, DatabaseContext>, IM100CertificatesDal
    {
        public List<M100CertificatesDto> GetM100CertificatesDto()
        {
            
                using (DatabaseContext context = new DatabaseContext())
                {
                    var result = from c in context.M100Certificates
                                 join p in context.M100Persons
                                 on c.PersonId equals p.PersonsId
                                 select new M100CertificatesDto { CertificatesId = c.CertificatesId, PersonId = p.PersonsId };
                    return result.ToList();
                }

            
        }
    }
}
