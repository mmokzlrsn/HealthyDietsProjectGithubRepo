using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100IpListManager : IM100IpListService
    {
        IM100IpListDal _m100IpListDal;

        public M100IpListManager(IM100IpListDal m100IpListDal)
        {
            _m100IpListDal = m100IpListDal;
        }

        public IResult Add(M100IpList m100IpList)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100IpList m100IpList)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100IpList>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100IpList> GetById(int m100IpListId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100IpList m100IpList)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100IpList m100IpList)
        {
            throw new NotImplementedException();
        }
    }
}
