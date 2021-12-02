using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100EmployeeOperationClaimsManager: IM100EmployeeOperationClaimsService
    {
        IM100EmployeeOperationClaimsDal _m100EmployeeOperationClaims;

        public M100EmployeeOperationClaimsManager(IM100EmployeeOperationClaimsDal m100EmployeeOperationClaims)
        {
            _m100EmployeeOperationClaims = m100EmployeeOperationClaims;
        }

        public IResult Add(M100EmployeeOperationClaims employeeOperationClaims)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100EmployeeOperationClaims employeeOperationClaims)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100EmployeeOperationClaims>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100EmployeeOperationClaims> GetById(int m100EmployeeOperationClaimsId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100EmployeeOperationClaims employeeOperationClaims)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100EmployeeOperationClaims employeeOperationClaims)
        {
            throw new NotImplementedException();
        }
    }
}
