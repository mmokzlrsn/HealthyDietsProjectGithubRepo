using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100EmailContentManager: IM100EmailContentService
    {
        IM100EmailContentDal _m100EmailContentDal;

        public M100EmailContentManager(IM100EmailContentDal m100EmailContentDal)
        {
            _m100EmailContentDal = m100EmailContentDal;
        }

        public IDataResult<List<M100EmailContent>> GetAll()
        {
            return new SuccessDataResult<List<M100EmailContent>>(_m100EmailContentDal.GetAll());
        }
    }
}
