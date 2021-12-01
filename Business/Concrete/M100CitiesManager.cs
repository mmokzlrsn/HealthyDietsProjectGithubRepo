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

        public IDataResult<List<M100Cities>> GetAll()
        {
           return new SuccessDataResult<List<M100Cities>>(_m100CitiesDal.GetAll());
        }
    }
}
