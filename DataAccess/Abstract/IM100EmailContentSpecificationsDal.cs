using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100EmailContentSpecificationsDal : IEntityRepository<M100EmailContentSpecifications>
    {
        List<M100EmailContentSpecificationsDto> GetM100EmailContentSpecificationsDto();
    }
}
