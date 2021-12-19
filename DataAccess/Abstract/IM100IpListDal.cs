using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100IpListDal:IEntityRepository<M100IpList>
    {
        List<M100IpListDto> GetM100IpListDto();
    }
}
