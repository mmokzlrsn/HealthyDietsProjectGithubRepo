using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M102WhoListManager: IM102WhoListService
    {
        IM102WhoListDal _m102WhoListDal;

        public M102WhoListManager(IM102WhoListDal m102WhoListDal)
        {
            _m102WhoListDal = m102WhoListDal;
        }

        public IResult Add(M102WhoList m102WhoList)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M102WhoList m102WhoList)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M102WhoList>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M102WhoList> GetById(int m102WhoListId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M102WhoList m102WhoList)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M102WhoList m102WhoList)
        {
            throw new NotImplementedException();
        }
    }
}
