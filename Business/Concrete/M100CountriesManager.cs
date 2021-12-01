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

        public IDataResult<List<M100Countries>> GetAll()
        {
            return new SuccessDataResult<List<M100Countries>>(_m100CountriesDal.GetAll());
        }
    }
}
