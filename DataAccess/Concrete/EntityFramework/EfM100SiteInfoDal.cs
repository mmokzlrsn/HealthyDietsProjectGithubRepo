using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100SiteInfoDal : EfEntityRepositoryBase<M100SiteInfo, DatabaseContext>, IM100SiteInfoDal
    {
        public List<M100SiteInfoDto> GetM100SiteInfoDto()
        {
            throw new NotImplementedException();
        }
    }
}
