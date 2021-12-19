using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100VerificationsDal:IEntityRepository<M100Verifications>
    {
        List<M100VerificationsDto> GetM100VerificationsDto();
    }
}
