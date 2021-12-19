using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100SiteInfoDal:IEntityRepository<M100SiteInfo>
    {
        List<M100SiteInfoDto> GetM100SiteInfoDto();
    }
}
