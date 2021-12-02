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

        public IResult Add(M100EmailContent m100EmailContent)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100EmailContent m100EmailContent)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100EmailContent>> GetAll()
        {
            return new SuccessDataResult<List<M100EmailContent>>(_m100EmailContentDal.GetAll());
        }

        public IDataResult<M100EmailContent> GetById(int m100EmailContentId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100EmailContent m100EmailContent)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100EmailContent m100EmailContent)
        {
            throw new NotImplementedException();
        }
    }
}
