using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100SocialMediaAccountsDal:IEntityRepository<M100SocialMediaAccounts>
    {
        List<M100SocialMediaAccountsDto> GetM100SocialMediaAccountsDto();
    }
}
