using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100TimeZoneDal:IEntityRepository<M100TimeZone>
    {
        List<M100TimeZoneDto> GetM100TimeZoneDto();
    }
}
