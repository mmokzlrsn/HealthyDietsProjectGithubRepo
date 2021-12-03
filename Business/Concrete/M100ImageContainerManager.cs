using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100ImageContainerManager: IM100ImageContainerService
    {
        IM100ImageContainerDal _m100ImageContainer;

        public M100ImageContainerManager(IM100ImageContainerDal m100ImageContainer)
        {
            _m100ImageContainer = m100ImageContainer;
        }

        public IResult Add(M100ImageContainer m100ImageContainer)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100ImageContainer m100ImageContainer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100ImageContainer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100ImageContainer> GetById(int m100ImageContainerId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100ImageContainer m100ImageContainer)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100ImageContainer m100ImageContainer)
        {
            throw new NotImplementedException();
        }
    }
}
