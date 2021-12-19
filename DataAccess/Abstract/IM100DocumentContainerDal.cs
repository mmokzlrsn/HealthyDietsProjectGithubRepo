using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100DocumentContainerDal:IEntityRepository<M100DocumentContainer>
    {
        List<M100DocumentContainerDto> GetM100DocumentContainerDtos();
    }
}
