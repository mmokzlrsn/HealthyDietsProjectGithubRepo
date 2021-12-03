using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100OperationClaimsManager: IM100OperationClaimsService
    {
        IM100OperationClaimsDal _m100OperationClaimsDal;

        public M100OperationClaimsManager(IM100OperationClaimsDal m100OperationClaimsDal)
        {
            _m100OperationClaimsDal = m100OperationClaimsDal;
        }

        public IResult Add(M100OperationClaims m100OperationClaims)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100OperationClaims m100OperationClaims)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100OperationClaims>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100OperationClaims> GetById(int m100OperationClaimsId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100OperationClaims m100OperationClaims)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100OperationClaims m100OperationClaims)
        {
            throw new NotImplementedException();
        }
    }
}
