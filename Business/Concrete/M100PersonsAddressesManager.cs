using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100PersonsAddressesManager : IM100PersonsAddressesService
    {
        IM100PersonsAddressesDal _m100PersonsAddressesDal;

        public M100PersonsAddressesManager(IM100PersonsAddressesDal m100PersonsAddressesDal)
        {
            _m100PersonsAddressesDal = m100PersonsAddressesDal;
        }

        public IResult Add(M100PersonsAddresses m100PersonsAddresses)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100PersonsAddresses m100PersonsAddresses)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100PersonsAddresses>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100PersonsAddresses> GetById(int m100PersonsAddressesId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100PersonsAddresses m100PersonsAddresses)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100PersonsAddresses m100PersonsAddresses)
        {
            throw new NotImplementedException();
        }
    }
}
