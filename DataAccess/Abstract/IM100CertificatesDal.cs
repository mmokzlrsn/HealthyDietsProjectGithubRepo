using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100CertificatesDal:IEntityRepository<M100Certificates>
    {
        List<M100CertificatesDto> GetM100CertificatesDto();
    }
}
