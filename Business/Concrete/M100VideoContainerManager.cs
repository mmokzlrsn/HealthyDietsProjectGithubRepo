using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100VideoContainerManager: IM100VideoContainerService
    {
        IM100VideoContainerDal _m100VideoContainerDal;

        public M100VideoContainerManager(IM100VideoContainerDal m100VideoContainerDal)
        {
            _m100VideoContainerDal = m100VideoContainerDal;
        }

        public IResult Add(M100VideoContainer m100VideoContainer)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100VideoContainer m100VideoContainer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100VideoContainer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100VideoContainer> GetById(int m100VideoContainerId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100VideoContainer m100VideoContainer)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100VideoContainer m100VideoContainer)
        {
            throw new NotImplementedException();
        }
    }
}
