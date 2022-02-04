using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100EmployeeDal : EfEntityRepositoryBase<M100Employee, DatabaseContext>, IM100EmployeeDal
    {
        public List<M100EmployeeDto> GetM100EmployeeDto()
        {
            throw new NotImplementedException();
        }
    }
}
