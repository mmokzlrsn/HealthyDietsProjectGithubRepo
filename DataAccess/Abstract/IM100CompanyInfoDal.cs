using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100CompanyInfoDal : IEntityRepository<M100CompanyInfo>
    {
        List<M100CompanyInfoDto> GetM100CompanyInfoDto();
    }
}
