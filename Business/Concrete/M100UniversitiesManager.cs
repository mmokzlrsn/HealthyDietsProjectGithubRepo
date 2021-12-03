using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100UniversitiesManager: IM100UniversitiesService
    {
        IM100UniversitiesDal _m100UniversitiesDal;

        public M100UniversitiesManager(IM100UniversitiesDal m100UniversitiesDal)
        {
            _m100UniversitiesDal = m100UniversitiesDal;
        }

        public IResult Add(M100Universities m100Universities)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100Universities m100Universities)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100Universities>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100Universities> GetById(int m100UniversitiesId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100Universities m100Universities)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100Universities m100Universities)
        {
            throw new NotImplementedException();
        }
    }
}
