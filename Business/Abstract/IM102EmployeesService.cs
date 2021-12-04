using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM102EmployeesService
    {
        IDataResult<List<M102Employees>> GetAll();
        IDataResult<M102Employees> GetById(int m102EmployeesId);
        IResult Add(M102Employees m102Employees);
        IResult Update(M102Employees m102Employees);
        IResult Delete(M102Employees m102Employees);
        IResult Kill(M102Employees m102Employees);

    }
}
