using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM102WhoListDal:IEntityRepository<M102WhoList>
    {
        List<M102WhoListDto> GetM102WhoListDto();
    }
}
