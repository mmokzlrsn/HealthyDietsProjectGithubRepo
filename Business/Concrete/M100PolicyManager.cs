using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100PolicyManager: IM100PolicyService
    {
        IM100PolicyDal _m100Policy;

        public M100PolicyManager(IM100PolicyDal m100Policy)
        {
            _m100Policy = m100Policy;
        }

        public IResult Add(M100Policy m100Policy)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100Policy m100Policy)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100Policy>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100Policy> GetById(int m100PolicyId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100Policy m100Policy)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100Policy m100Policy)
        {
            throw new NotImplementedException();
        }
    }
}
