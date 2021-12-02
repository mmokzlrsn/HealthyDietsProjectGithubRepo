using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100EmployeeManager: IM100EmployeeService
    {
        IM100EmployeeDal _m100EmployeeDal;

        public M100EmployeeManager(IM100EmployeeDal m100EmployeeDal)
        {
            _m100EmployeeDal = m100EmployeeDal;
        }

        public IResult Add(M100Employee m100Employee)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100Employee m100Employee)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100Employee>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100Employee> GetById(int m100EmployeeId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100Employee m100Employee)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100Employee m100Employee)
        {
            throw new NotImplementedException();
        }
    }
}
