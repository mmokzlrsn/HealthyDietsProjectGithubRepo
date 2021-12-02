using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100CompanyAddressesManager : IM100CompanyAddressesService
    {
        IM100CompanyAddressesDal _m100CompanyAddressesDal;

        public M100CompanyAddressesManager(IM100CompanyAddressesDal m100CompanyAddressesDal)
        {
            _m100CompanyAddressesDal = m100CompanyAddressesDal;
        }

        public IResult Add(M100CompanyAddresses m100CompanyAddresses)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100CompanyAddresses m100CompanyAddresses)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100CompanyAddresses>> GetAll()
        {
            return new SuccessDataResult<List<M100CompanyAddresses>>(_m100CompanyAddressesDal.GetAll());
        }

        public IDataResult<M100CompanyAddresses> GetById(int m100CompanyAddressesId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100CompanyAddresses m100CompanyAddresses)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100CompanyAddresses m100CompanyAddresses)
        {
            throw new NotImplementedException();
        }
    }
}
