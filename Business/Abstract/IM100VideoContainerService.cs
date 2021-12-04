using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100VideoContainerService
    {
        IDataResult<List<M100VideoContainer>> GetAll();
        IDataResult<M100VideoContainer> GetById(int m100VideoContainerId);
        IResult Add(M100VideoContainer m100VideoContainer);
        IResult Update(M100VideoContainer m100VideoContainer);
        IResult Delete(M100VideoContainer m100VideoContainer);
        IResult Kill(M100VideoContainer m100VideoContainer);

    }
}
