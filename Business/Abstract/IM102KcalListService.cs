using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM102KcalListService
    {
        IDataResult<List<M102KcalList>> GetAll();
        IDataResult<M102KcalList> GetById(int m102KcalListId);
        IResult Add(M102KcalList m102KcalList);
        IResult Update(M102KcalList m102KcalList);
        IResult Delete(M102KcalList m102KcalList);
        IResult Kill(M102KcalList m102KcalList);
    }
}
