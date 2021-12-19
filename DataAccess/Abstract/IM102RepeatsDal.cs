using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM102RepeatsDal:IEntityRepository<M102Repeats>
    {
        List<M102RepeatsDto> GetM102RepeatsDto();
    }
}
