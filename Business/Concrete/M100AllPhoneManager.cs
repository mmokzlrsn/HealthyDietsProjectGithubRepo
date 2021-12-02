using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100AllPhoneManager : IM100AllPhoneService
    {
        IM100AllPhoneDal _m100AllPhoneDal;

        public M100AllPhoneManager(IM100AllPhoneDal m100AllPhoneDal)
        {
            _m100AllPhoneDal = m100AllPhoneDal;
        }

        public IResult Add(M100AddressBook m100AddressBook)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100AddressBook m100AddressBook)
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100AddressBook> GetById(int m100AddressBookId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100AddressBook m100AddressBook)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100AddressBook m100AddressBook)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<M100AllPhone>> IM100AllPhoneService.GetAll()
        {
            return new SuccessDataResult<List<M100AllPhone>>(_m100AllPhoneDal.GetAll());
        }
    }
}
