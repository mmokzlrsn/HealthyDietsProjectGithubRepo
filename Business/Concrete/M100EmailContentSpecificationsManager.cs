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

        public IDataResult<List<M100EmailContentSpecifications>> GetAll()
        {
            return new SuccessDataResult<List<M100EmailContentSpecifications>>(_m100EmailContentSpecificationsDal.GetAll());
        }
    }
}
