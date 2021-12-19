using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100DepartmentDal:IEntityRepository<M100Department>
    {
        List<M100DepartmentDto> GetM100DepartmentDto();
    }
}
