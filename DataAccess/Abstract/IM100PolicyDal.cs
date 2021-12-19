using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100PolicyDal:IEntityRepository<M100Policy>
    {
        List<M100PersonsDto> GetM100PersonsDto();
    }
}
