using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100TimeZoneService
    {
        IDataResult<List<M100TimeZone>> GetAll();
        IDataResult<M100TimeZone> GetById(int m100TimeZoneId);
        IResult Add(M100TimeZone m100TimeZone);
        IResult Update(M100TimeZone m100TimeZone);
        IResult Delete(M100TimeZone m100TimeZone);
        IResult Kill(M100TimeZone m100TimeZone);

    }
}
