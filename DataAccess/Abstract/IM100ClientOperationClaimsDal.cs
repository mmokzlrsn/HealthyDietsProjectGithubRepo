using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100ClientOperationClaimsDal:IEntityRepository<M100ClientOperationClaims>
    {
        List<M100ClientOperationClaimsDto> GetM100ClientOperationClaimsDto();
    }
}
