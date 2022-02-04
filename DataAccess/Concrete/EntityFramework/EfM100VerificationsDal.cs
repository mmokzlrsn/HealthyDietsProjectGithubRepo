using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100VerificationsDal : EfEntityRepositoryBase<M100Verifications, DatabaseContext>, IM100VerificationsDal
    {
        public List<M100VerificationsDto> GetM100VerificationsDto()
        {
            throw new NotImplementedException();
        }
    }
}
