using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100EmailControlManager: IM100EmailControlService
    {
        IM100EmailControlDal _m100EmailControlDal;

        public M100EmailControlManager(IM100EmailControlDal m100EmailControlDal)
        {
            _m100EmailControlDal = m100EmailControlDal;
        }

        public IResult Add(M100EmailControl m100EmailControl)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100EmailControl m100EmailControl)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100EmailControl>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100EmailControl>> GetById(int m100EmailControlId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100EmailControl m100EmailControl)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100EmailControl m100EmailControl)
        {
            throw new NotImplementedException();
        }
    }
}
