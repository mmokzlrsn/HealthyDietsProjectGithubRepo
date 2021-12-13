using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM102WhoListService
    {
        IDataResult<List<M102WhoList>> GetAll();
        IDataResult<M102WhoList> GetById(int m102WhoListId);
        IResult Add(M102WhoList m102WhoList);
        IResult Update(M102WhoList m102WhoList);
        IResult Delete(M102WhoList m102WhoList);
        IResult Kill(M102WhoList m102WhoList);

    }
}
