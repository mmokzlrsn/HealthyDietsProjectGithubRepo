using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M102KcalListManager: IM102KcalListService
    {
        IM102KcalListDal _m102KcalListDal;

        public M102KcalListManager(IM102KcalListDal m102KcalListDal)
        {
            _m102KcalListDal = m102KcalListDal;
        }

        public IResult Add(M102KcalList m102KcalList)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M102KcalList m102KcalList)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M102KcalList>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M102KcalList> GetById(int m102KcalListId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M102KcalList m102KcalList)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M102KcalList m102KcalList)
        {
            throw new NotImplementedException();
        }
    }
}
