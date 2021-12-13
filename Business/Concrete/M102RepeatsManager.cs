using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M102RepeatsManager: IM102RepeatsService
    {
        IM102RepeatsDal _m102RepeatsDal;

        public M102RepeatsManager(IM102RepeatsDal m102RepeatsDal)
        {
            _m102RepeatsDal = m102RepeatsDal;
        }

        public IResult Add(M102Repeats m102Repeats)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M102Repeats m102Repeats)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M102Repeats>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M102Repeats> GetById()
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M102Repeats m102Repeats)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M102Repeats m102Repeats)
        {
            throw new NotImplementedException();
        }
    }
}
