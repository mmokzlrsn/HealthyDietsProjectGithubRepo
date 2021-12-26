using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100ClientOperationClaimsDal : EfEntityRepositoryBase<M100ClientOperationClaims, DatabaseContext>, IM100ClientOperationClaimsDal
    {
        public List<M100ClientOperationClaimsDto> GetM100ClientOperationClaimsDto()
        {
            throw new NotImplementedException();
        }
    }
}
