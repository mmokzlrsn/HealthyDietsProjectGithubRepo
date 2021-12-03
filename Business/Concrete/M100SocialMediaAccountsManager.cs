using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100SocialMediaAccountsManager: IM100SocialMediaAccountsService
    {
        IM100SocialMediaAccountsDal _m100SocialMediaAccountsDal;

        public M100SocialMediaAccountsManager(IM100SocialMediaAccountsDal m100SocialMediaAccountsDal)
        {
            _m100SocialMediaAccountsDal = m100SocialMediaAccountsDal;
        }

        public IResult Add(M100SocialMediaAccounts m100SocialMediaAccounts)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100SocialMediaAccounts m100SocialMediaAccounts)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100SocialMediaAccounts>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100SocialMediaAccounts> GetById(int m100SocialMediaAccountsId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100SocialMediaAccounts m100SocialMediaAccounts)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100SocialMediaAccounts m100SocialMediaAccounts)
        {
            throw new NotImplementedException();
        }
    }
}
