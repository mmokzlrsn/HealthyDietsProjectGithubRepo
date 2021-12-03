using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100SocialMediaAccountsService
    {
        IDataResult<List<M100SocialMediaAccounts>> GetAll();
        IDataResult<M100SocialMediaAccounts> GetById(int m100SocialMediaAccountsId);
        IResult Add(M100SocialMediaAccounts m100SocialMediaAccounts);
        IResult Update(M100SocialMediaAccounts m100SocialMediaAccounts);
        IResult Delete(M100SocialMediaAccounts m100SocialMediaAccounts);
        IResult Kill(M100SocialMediaAccounts m100SocialMediaAccounts);

    }
}
