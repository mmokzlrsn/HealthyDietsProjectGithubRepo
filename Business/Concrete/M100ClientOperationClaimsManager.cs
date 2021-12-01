using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100ClientOperationClaimsManager : IM100ClientOperationClaimsService
    {
        IM100ClientOperationClaimsDal _m100ClientOperationClaimsDal;

        public M100ClientOperationClaimsManager(IM100ClientOperationClaimsDal m100ClientOperationClaimsDal)
        {
            _m100ClientOperationClaimsDal = m100ClientOperationClaimsDal;
        }

        public IDataResult<List<M100ClientOperationClaims>> GetAll()
        {
            return new SuccessDataResult<List<M100ClientOperationClaims>>(_m100ClientOperationClaimsDal.GetAll());
        }
    }
}
