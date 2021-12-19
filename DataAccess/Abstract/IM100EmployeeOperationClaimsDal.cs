using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100EmployeeOperationClaimsDal:IEntityRepository<M100EmployeeOperationClaims>
    {
        List<M100EmployeeOperationClaimsDto> GetM100EmployeeOperationClaimsDto();
    }
}
