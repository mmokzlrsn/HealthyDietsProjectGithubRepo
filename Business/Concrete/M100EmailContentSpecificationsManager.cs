using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100EmailContentSpecificationsManager : IM100EmailContentSpecificationsService
    {
        IM100EmailContentSpecificationsDal _m100EmailContentSpecificationsDal;

        public M100EmailContentSpecificationsManager(IM100EmailContentSpecificationsDal m100EmailContentSpecificationsDal)
        {
            _m100EmailContentSpecificationsDal = m100EmailContentSpecificationsDal;
        }

        public IResult Add(M100EmailContentSpecifications m100AddressBook)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100EmailContentSpecifications M100EmailContentSpecifications)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100EmailContentSpecifications>> GetAll()
        {
            return new SuccessDataResult<List<M100EmailContentSpecifications>>(_m100EmailContentSpecificationsDal.GetAll());
        }

        public IDataResult<M100EmailContentSpecifications> GetById(int M100EmailContentSpecificationsId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100EmailContentSpecifications M100EmailContentSpecifications)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100EmailContentSpecifications M100EmailContentSpecifications)
        {
            throw new NotImplementedException();
        }
    }
}
