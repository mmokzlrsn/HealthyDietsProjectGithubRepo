using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100OperationClaimsDal:IEntityRepository<M100OperationClaims>
    {
        List<M100OperationClaimsDto> GetM100OperationClaimsDto();
    }
}
