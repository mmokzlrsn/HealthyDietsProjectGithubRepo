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

        public IResult Add(M100Admin m100Admin)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100Admin m100Admin)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100Admin>>GetAll()
        {
            return new SuccessDataResult<List<M100Admin>>(_m100AdminDal.GetAll());
        }

        public IDataResult<M100Admin> GetById(int m100AdminId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100Admin m100Admin)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100Admin m100Admin)
        {
            throw new NotImplementedException();
        }
    }
}
