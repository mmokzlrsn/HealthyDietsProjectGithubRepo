using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM102EmployeesDal : IEntityRepository<M102Employees>
    {
        List<M102EmployeesDto> GetM102EmployeesDto();
    }
}
