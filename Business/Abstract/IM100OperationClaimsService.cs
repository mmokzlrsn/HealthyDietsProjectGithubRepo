using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100OperationClaimsService
    {
        IDataResult<List<M100OperationClaims>> GetAll();
        IDataResult<M100OperationClaims> GetById(int m100OperationClaimsId);
        IResult Add(M100OperationClaims m100OperationClaims);
        IResult Update(M100OperationClaims m100OperationClaims);
        IResult Delete(M100OperationClaims m100OperationClaims);
        IResult Kill(M100OperationClaims m100OperationClaims);

    }
}
