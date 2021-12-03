using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100UniversitiesService
    {
        IDataResult<List<M100Universities>> GetAll();
        IDataResult<M100Universities> GetById(int m100UniversitiesId);
        IResult Add(M100Universities m100Universities);
        IResult Update(M100Universities m100Universities);
        IResult Delete(M100Universities m100Universities);
        IResult Kill(M100Universities m100Universities);

    }
}
