using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100PersonsAddressesDal : EfEntityRepositoryBase<M100PersonsAddresses, DatabaseContext>, IM100PersonsAddressesDal
    {
        public List<M100PersonsAddressesDto> GetPersonsAddressesDto()
        {
            throw new NotImplementedException();
        }
    }
}
