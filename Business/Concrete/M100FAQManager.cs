using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100FAQManager : IM100FAQService
    {
        IM100FAQDal _m100FAQDal;

        public M100FAQManager(IM100FAQDal m100FAQDal)
        {
            _m100FAQDal = m100FAQDal;
        }

        public IResult Add(M100FAQ m100FAQ)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100FAQ m100FAQ)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100FAQ>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100FAQ> GetById(int m100FAQId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100FAQ m100FAQ)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100FAQ m100FAQ)
        {
            throw new NotImplementedException();
        }
    }
}
