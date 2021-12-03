using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100MacListManager : IM100MacListService
    {
        IM100MacListDal _m100MacListDal;

        public M100MacListManager(IM100MacListDal m100MacListDal)
        {
            _m100MacListDal = m100MacListDal;
        }

        public IResult Add(M100MacList m100MacList)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100MacList m100MacList)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100MacList>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100MacList> GetById(int m100MacList)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100MacList m100MacList)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100MacList m100MacList)
        {
            throw new NotImplementedException();
        }
    }
}
