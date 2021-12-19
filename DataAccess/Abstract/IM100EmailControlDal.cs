using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100EmailControlDal:IEntityRepository<M100EmailControl>
    {
        List<M100EmailControlDto> GetM100EmailControlDto();
    }
}
