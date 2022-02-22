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
    public class EfM100CompanyAddressesDal : EfEntityRepositoryBase<M100CompanyAddresses, DatabaseContext>, IM100CompanyAddressesDal
    {
        public List<M100CompanyAddressesDto> GetM100CompanyAddressesDtos()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from ca in context.M100CompanyAddresses
                             join ci in context.M100CompanyInfo
                             on ca.CompanyInfoId equals ci.CompanyInfoId
                             select new M100CompanyAddressesDto
                             {
                                 CompanyAddressesId = ca.CompanyAddressesId, 
                                 CompanyInfoId = ci.CompanyInfoId,
                                 CityId = ca.CityId
                             
                             };
                return result.ToList();
            }
        }
    }
}
