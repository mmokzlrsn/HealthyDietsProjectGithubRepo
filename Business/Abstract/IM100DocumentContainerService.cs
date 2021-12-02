using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100DocumentContainerService
    {
        IDataResult<List<M100DocumentContainer>> GetAll();
        IDataResult<M100DocumentContainer> GetById(int m100DocumentContainerId); //filtered get
        IResult Add(M100DocumentContainer m100DocumentContainer); //adds new Data
        IResult Update(M100DocumentContainer m100DocumentContainer); //UPDATEs information
        IResult Delete(M100DocumentContainer m100DocumentContainer); // update the isDeleted
        IResult Kill(M100DocumentContainer m100DocumentContainer); // deletes compeletly
    }
}
