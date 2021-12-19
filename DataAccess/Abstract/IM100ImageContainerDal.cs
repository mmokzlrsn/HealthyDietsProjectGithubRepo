using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100ImageContainerDal:IEntityRepository<M100ImageContainer>
    {
        List<M100ImageContainerDto> GetM100ImageContainerDto();
    }
}
