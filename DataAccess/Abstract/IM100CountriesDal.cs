using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100CountriesDal:IEntityRepository<M100Countries>
    {
        List<M100CountriesDto> GetM100CountriesDto();
    }
}
