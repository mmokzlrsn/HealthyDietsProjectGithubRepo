using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100AllEmailAddressDal:IEntityRepository<M100AllEmailAddress>
    {
        List<M100AllEmailAddressDto> GetM100AllEmailAddressDto();
    }
}
