using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M102DietListManager: IM102DietListService
    {
        IM102DietListDal _m102DietListDal;

        public M102DietListManager(IM102DietListDal m102DietListDal)
        {
            _m102DietListDal = m102DietListDal;
        }

        public IResult Add(M102DietList m102DietList)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M102DietList m102DietList)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M102DietList>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M102DietList> GetById(int m102DietListId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M102DietList m102DietList)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M102DietList m102DietList)
        {
            throw new NotImplementedException();
        }
    }
}
