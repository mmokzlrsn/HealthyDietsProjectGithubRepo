using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100StatesDal:IEntityRepository<M100States>
    {
        List<M100StatesDto> GetM100StatesDto();
    }
}
