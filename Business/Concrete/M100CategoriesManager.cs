using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100CategoriesManager : IM100CategoriesService
    {
        IM100CategoriesDal _m100CategoriesDal;

        public M100CategoriesManager(IM100CategoriesDal m100CategoriesDal)
        {
            _m100CategoriesDal = m100CategoriesDal;
        }

        public IDataResult<List<M100Categories>> GetAll()
        {
            return new SuccessDataResult<List<M100Categories>>(_m100CategoriesDal.GetAll());
        }
    }
}
