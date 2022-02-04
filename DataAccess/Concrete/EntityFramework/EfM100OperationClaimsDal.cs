using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100OperationClaimsDal : EfEntityRepositoryBase<M100OperationClaims, DatabaseContext>, IM100OperationClaimsDal
    {
        public List<M100OperationClaimsDto> GetM100OperationClaimsDto()
        {
            throw new NotImplementedException();
        }
    }
}
