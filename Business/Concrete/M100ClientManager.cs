using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100ClientManager : IM100ClientService
    {
        IM100ClientDal _m100ClientDal;

        public M100ClientManager(IM100ClientDal m100ClientDal)
        {
            _m100ClientDal = m100ClientDal;
        }

        public IResult Add(M100Client m100Client)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100Client m100Client)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100Client>> GetAll()
        {
            return new SuccessDataResult<List<M100Client>>(_m100ClientDal.GetAll());
        }

        public IDataResult<M100Client> GetById(int m100ClientId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100Client m100Client)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100Client m100Client)
        {
            throw new NotImplementedException();
        }
    }
}
