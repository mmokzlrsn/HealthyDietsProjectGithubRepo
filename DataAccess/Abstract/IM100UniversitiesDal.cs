using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100UniversitiesDal:IEntityRepository<M100Universities>
    {
        List<M100UniversitiesDto> GetM100UniversitiesDto();
    }
}
