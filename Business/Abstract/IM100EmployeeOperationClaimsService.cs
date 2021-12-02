using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100EmployeeOperationClaimsService
    {
        IDataResult<List<M100EmployeeOperationClaims>> GetAll();
        IDataResult<M100EmployeeOperationClaims> GetById(int m100EmployeeOperationClaimsId);
        IResult Add(M100EmployeeOperationClaims employeeOperationClaims);
        IResult Update(M100EmployeeOperationClaims employeeOperationClaims);
        IResult Delete(M100EmployeeOperationClaims employeeOperationClaims);
        IResult Kill(M100EmployeeOperationClaims employeeOperationClaims);
    }
}
