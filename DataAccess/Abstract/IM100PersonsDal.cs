using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IM100PersonsDal : IEntityRepository<M100Persons>
    {
        List<M100PersonsDto> GetM100PersonsDto();
    }
}
