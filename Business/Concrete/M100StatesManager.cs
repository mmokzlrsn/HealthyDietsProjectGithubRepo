using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100StatesManager: IM100StatesService
    {
        IM100StatesDal _m100StatesDal;

        public M100StatesManager(IM100StatesDal m100StatesDal)
        {
            _m100StatesDal = m100StatesDal;
        }

        public IResult Add(M100States m100States)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100States m100States)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100States>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100States> GetById(int m100StatesId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100States m100States)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100States m100States)
        {
            throw new NotImplementedException();
        }
    }
}
