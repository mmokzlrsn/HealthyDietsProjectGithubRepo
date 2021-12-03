using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100PersonsService
    {
        IDataResult<List<M100Persons>> GetAll();
        IDataResult<M100Persons> GetById(int m100PersonsId);
        IResult Add(M100Persons m100Persons);
        IResult Update(M100Persons m100Persons);
        IResult Delete(M100Persons m100Persons);
        IResult Kill(M100Persons m100Persons);
    }
}
