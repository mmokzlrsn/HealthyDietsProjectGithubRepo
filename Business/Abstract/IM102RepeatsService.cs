using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM102RepeatsService
    {
        IDataResult<List<M102Repeats>> GetAll();
        IDataResult<M102Repeats> GetById();
        IResult Add(M102Repeats m102Repeats);
        IResult Update(M102Repeats m102Repeats);
        IResult Delete(M102Repeats m102Repeats);
        IResult Kill(M102Repeats m102Repeats);


    }
}
