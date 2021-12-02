using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100AllEmailAddressManager : IM100AllEmailAddressService
    {
        IM100AllEmailAddressDal _m100AllEmailAddressDal;

        public M100AllEmailAddressManager(IM100AllEmailAddressDal m100AllEmailAddressDal)
        {
            _m100AllEmailAddressDal = m100AllEmailAddressDal;
        }

        public IResult Add(M100AllEmailAddress m100AllEmailAddress)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100AllEmailAddress m100AllEmailAddress)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100AllEmailAddress>> GetAll()
        {
            return new SuccessDataResult<List<M100AllEmailAddress>>(_m100AllEmailAddressDal.GetAll());
        }

        public IDataResult<M100AllEmailAddress> GetById(int m100AllEmailAddressId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100AllEmailAddress m100AllEmailAddress)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100AllEmailAddress m100AllEmailAddress)
        {
            throw new NotImplementedException();
        }
    }
}
