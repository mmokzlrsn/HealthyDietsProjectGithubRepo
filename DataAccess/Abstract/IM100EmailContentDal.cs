using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100EmailContentDal:IEntityRepository<M100EmailContent>
    {
        List<M100EmailContentDto> GetM100EmailContentDto();
    }
}
