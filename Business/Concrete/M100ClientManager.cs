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

        public IDataResult<List<M100Client>> GetAll()
        {
            return new SuccessDataResult<List<M100Client>>(_m100ClientDal.GetAll());
        }
    }
}
