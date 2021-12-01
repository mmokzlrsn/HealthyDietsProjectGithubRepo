using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100AdminManager: IM100AdminService
    {
        IM100AdminDal _m100AdminDal;

        public M100AdminManager(IM100AdminDal m100AdminDal)
        {
            _m100AdminDal = m100AdminDal;
        }

        public IDataResult<List<M100Admin>>GetAll()
        {
            return new SuccessDataResult<List<M100Admin>>(_m100AdminDal.GetAll());
        }
        
    }
}
