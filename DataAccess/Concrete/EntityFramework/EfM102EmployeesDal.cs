using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM102EmployeesDal : EfEntityRepositoryBase<M102Employees, DatabaseContext>, IM102EmployeesDal
    {
        public List<M102EmployeesDto> GetM102EmployeesDto()
        {
            throw new NotImplementedException();
        }
    }
}
