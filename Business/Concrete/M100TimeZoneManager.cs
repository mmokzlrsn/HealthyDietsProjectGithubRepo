using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100TimeZoneManager: IM100TimeZoneService
    {
        IM100TimeZoneDal _m100TimeZoneDal;

        public M100TimeZoneManager(IM100TimeZoneDal m100TimeZoneDal)
        {
            _m100TimeZoneDal = m100TimeZoneDal;
        }

        public IResult Add(M100TimeZone m100TimeZone)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100TimeZone m100TimeZone)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100TimeZone>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100TimeZone> GetById(int m100TimeZoneId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100TimeZone m100TimeZone)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100TimeZone m100TimeZone)
        {
            throw new NotImplementedException();
        }
    }
}
