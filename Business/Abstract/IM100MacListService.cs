using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100MacListService
    {
        IDataResult<List<M100MacList>> GetAll();
        IDataResult<M100MacList> GetById(int m100MacList);
        IResult Add(M100MacList m100MacList);
        IResult Update(M100MacList m100MacList);
        IResult Delete(M100MacList m100MacList);
        IResult Kill(M100MacList m100MacList);

    }
}
