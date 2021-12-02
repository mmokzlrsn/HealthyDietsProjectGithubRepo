using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100CitiesManager : IM100CitiesService
    {
        IM100CitiesDal _m100CitiesDal;

        public M100CitiesManager(IM100CitiesDal m100CitiesDal)
        {
            _m100CitiesDal = m100CitiesDal;
        }

        public IResult Add(M100Cities m100Cities)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100Cities m100Cities)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100Cities>> GetAll()
        {
           return new SuccessDataResult<List<M100Cities>>(_m100CitiesDal.GetAll());
        }

        public IDataResult<M100Cities> GetById(int m100CitiesId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100Cities m100Cities)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100Cities m100Cities)
        {
            throw new NotImplementedException();
        }
    }
}
