using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100PersonsAddressesDal:IEntityRepository<M100PersonsAddresses>
    {
        List<M100PersonsAddressesDto> GetPersonsAddressesDto();
    }
}
