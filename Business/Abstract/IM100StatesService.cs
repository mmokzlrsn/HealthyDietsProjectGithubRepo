using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100StatesService
    {
        IDataResult<List<M100States>> GetAll();
        IDataResult<M100States> GetById(int m100StatesId);

        IResult Add(M100States m100States);
        IResult Update(M100States m100States);
        IResult Delete(M100States m100States);
        IResult Kill(M100States m100States);      

    }
}
