using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100CompanyAddressesDal : EfEntityRepositoryBase<M100CompanyAddresses, DatabaseContext>, IM100CompanyAddressesDal
    {
        public List<M100CompanyAddressesDto> GetM100CompanyAddressesDtos()
        {
            throw new NotImplementedException();
        }
    }
}
