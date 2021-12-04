using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M102EmployeesManager: IM102EmployeesService
    {
        IM102EmployeesDal _m102EmployeesDal;

        public M102EmployeesManager(IM102EmployeesDal m102EmployeesDal)
        {
            _m102EmployeesDal = m102EmployeesDal;
        }

        public IResult Add(M102Employees m102Employees)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M102Employees m102Employees)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M102Employees>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M102Employees> GetById(int m102EmployeesId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M102Employees m102Employees)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M102Employees m102Employees)
        {
            throw new NotImplementedException();
        }
    }
}
