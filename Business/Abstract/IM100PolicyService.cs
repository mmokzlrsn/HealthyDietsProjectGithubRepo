using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100PolicyService
    {
        IDataResult<List<M100Policy>> GetAll();
        IDataResult<M100Policy> GetById(int m100PolicyId);
        IResult Add(M100Policy m100Policy);
        IResult Update(M100Policy m100Policy);
        IResult Delete(M100Policy m100Policy);
        IResult Kill(M100Policy m100Policy);


    }
}
