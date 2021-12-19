using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100CompanyAddressesDal:IEntityRepository<M100CompanyAddresses>
    {
        List<M100CompanyAddressesDto> GetM100CompanyAddressesDtos();
    }
}
