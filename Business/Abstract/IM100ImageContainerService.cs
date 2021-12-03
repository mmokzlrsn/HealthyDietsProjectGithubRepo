using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100ImageContainerService
    {
        IDataResult<List<M100ImageContainer>> GetAll();
        IDataResult<M100ImageContainer> GetById(int m100ImageContainerId);
        IResult Add(M100ImageContainer m100ImageContainer);
        IResult Update(M100ImageContainer m100ImageContainer);
        IResult Delete(M100ImageContainer m100ImageContainer);
        IResult Kill(M100ImageContainer m100ImageContainer);

    }
}
