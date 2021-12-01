using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100ArticleManager : IM100ArticleService
    {
        IM100ArticleDal _m100ArticleDal;

        public M100ArticleManager(IM100ArticleDal m100ArticleDal)
        {
            _m100ArticleDal = m100ArticleDal;
        }

        public IDataResult<List<M100Article>>GetAll()
        {
            return new SuccessDataResult<List<M100Article>>(_m100ArticleDal.GetAll());
        }
    }
}
