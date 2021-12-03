using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100PersonsManager: IM100PersonsService
    {
        IM100PersonsDal _m100PersonsDal;

        public M100PersonsManager(IM100PersonsDal m100PersonsDal)
        {
            _m100PersonsDal = m100PersonsDal;
        }

        public IResult Add(M100Persons m100Persons)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100Persons m100Persons)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100Persons>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100Persons> GetById(int m100PersonsId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100Persons m100Persons)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100Persons m100Persons)
        {
            throw new NotImplementedException();
        }
    }
}
