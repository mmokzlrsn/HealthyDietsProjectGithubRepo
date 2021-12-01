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

        public IDataResult<List<M100CompanyAddresses>> GetAll()
        {
            return new SuccessDataResult<List<M100CompanyAddresses>>(_m100CompanyAddressesDal.GetAll());
        }
    }
}
