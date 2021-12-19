using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM102RepeatsTypeDal:IEntityRepository<M102RepeatsType>
    {
        List<M102RepeatsTypeDto> GetM102RepeatsTypeDto();
    }
}
