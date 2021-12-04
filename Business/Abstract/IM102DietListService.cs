using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM102DietListService
    {
        IDataResult<List<M102DietList>> GetAll();
        IDataResult<M102DietList> GetById(int m102DietListId);
        IResult Add(M102DietList m102DietList);
        IResult Update(M102DietList m102DietList);
        IResult Delete(M102DietList m102DietList);
        IResult Kill(M102DietList m102DietList);

    }
}
