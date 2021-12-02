using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100CountriesManager : IM100CountriesService
    {
        IM100CountriesDal _m100CountriesDal;

        public M100CountriesManager(IM100CountriesDal m100CountriesDal)
        {
            _m100CountriesDal = m100CountriesDal;
        }

        public IResult Add(M100Countries m100Countries)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100Countries m100Countries)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100Countries>> GetAll()
        {
            return new SuccessDataResult<List<M100Countries>>(_m100CountriesDal.GetAll());
        }

        public IDataResult<M100Countries> GetById(int m100CountriesId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100Countries m100Countries)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100Countries m100Countries)
        {
            throw new NotImplementedException();
        }
    }
}
