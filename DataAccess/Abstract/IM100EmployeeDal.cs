using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IM100EmployeeDal : IEntityRepository<M100Employee>
    {
        List<M100EmployeeDto> GetM100EmployeeDto();
    }
}
