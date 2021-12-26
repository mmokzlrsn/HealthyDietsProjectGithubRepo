using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100CompanyInfoDal : EfEntityRepositoryBase<M100CompanyInfo, DatabaseContext>, IM100CompanyInfoDal
    {
        public List<M100CompanyInfoDto> GetM100CompanyInfoDto()
        {
            throw new NotImplementedException();
        }
    }
}
