using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100SocialMediaAccountsDal : EfEntityRepositoryBase<M100SocialMediaAccounts, DatabaseContext>, IM100SocialMediaAccountsDal
    {
        public List<M100SocialMediaAccountsDto> GetM100SocialMediaAccountsDto()
        {
            throw new NotImplementedException();
        }
    }
}
