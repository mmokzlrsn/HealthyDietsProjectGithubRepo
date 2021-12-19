using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100MacListDal:IEntityRepository<M100MacList>
    {
        List<M100MacListDto> GetM100MacListDto();
    }
}
