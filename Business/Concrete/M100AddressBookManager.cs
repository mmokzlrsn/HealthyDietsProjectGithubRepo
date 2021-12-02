using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100AddressBookManager: IM100AddressBookService
    {
        IM100AddressBookDal _m100AddressBookDal;

        public M100AddressBookManager(IM100AddressBookDal m100AddressBookDal)
        {
            _m100AddressBookDal = m100AddressBookDal;
        }

        public IResult Add(M100AddressBook m100AddressBook)
        {
            //business codes
            if(m100AddressBook.AddressField1.Length<2) //öylesine kod denemelik
            {
                return new ErrorResult("AddressField's should be more than 1 char");
            }

            _m100AddressBookDal.Add(m100AddressBook);

            return new SuccessResult("AddressBook is added");
        }

        public IResult Delete(M100AddressBook m100AddressBook)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100AddressBook>> GetAll()
        {
            if(DateTime.Now.Hour == 22) //öylesine kod denemelik
            {
                return new ErrorDataResult<List<M100AddressBook>>(Messages.FailTestMessage);
            }

            return new SuccessDataResult<List<M100AddressBook>>(_m100AddressBookDal.GetAll(),Messages.PassTestMessage);
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
    }

}
