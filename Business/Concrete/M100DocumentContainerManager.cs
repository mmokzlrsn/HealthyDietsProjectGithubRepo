using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100DocumentContainerManager : IM100DocumentContainerService
    {
        IM100DocumentContainerDal _m100DocumentContainerDal;

        public M100DocumentContainerManager(IM100DocumentContainerDal m100DocumentContainerDal)
        {
            _m100DocumentContainerDal = m100DocumentContainerDal;
        }

        public IDataResult<List<M100DocumentContainer>> GetAll()
        {
            return new SuccessDataResult<List<M100DocumentContainer>>(_m100DocumentContainerDal.GetAll());
        }
    }
}
