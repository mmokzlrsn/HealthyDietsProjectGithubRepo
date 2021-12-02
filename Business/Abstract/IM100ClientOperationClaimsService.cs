using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100ClientOperationClaimsService
    {
        IDataResult<List<M100ClientOperationClaims>> GetAll();
        IDataResult<M100ClientOperationClaims> GetById(int m100ClientOperationClaimsId); //filtered get
        IResult Add(M100ClientOperationClaims m100ClientOperationClaims); //adds new Data
        IResult Update(M100ClientOperationClaims m100ClientOperationClaims); //UPDATEs information
        IResult Delete(M100ClientOperationClaims m100ClientOperationClaims); // update the isDeleted
        IResult Kill(M100ClientOperationClaims m100ClientOperationClaims); // deletes compeletly
    }
}
