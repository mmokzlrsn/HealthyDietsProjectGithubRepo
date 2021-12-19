using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100DepartmentDetailsDal:IEntityRepository<M100DepartmentDetails>
    {
        List<M100DepartmentDetailsDto> GetM100DepartmentDetailsDto();
    }
}
