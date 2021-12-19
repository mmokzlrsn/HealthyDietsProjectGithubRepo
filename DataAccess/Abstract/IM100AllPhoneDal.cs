using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100AllPhoneDal :IEntityRepository<M100AllPhone>
    {
        List<M100AllPhoneDto> GetM100AllPhoneDto();
    }
}
