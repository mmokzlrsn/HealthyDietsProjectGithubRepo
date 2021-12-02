using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
namespace Business.Abstract
{
    public interface IM100CitiesService
    {
        IDataResult<List<M100Cities>> GetAll();
        IDataResult<M100Cities> GetById(int m100CitiesId); //filtered get
        IResult Add(M100Cities m100Cities); //adds new Data
        IResult Update(M100Cities m100Cities); //UPDATEs information
        IResult Delete(M100Cities m100Cities); // update the isDeleted
        IResult Kill(M100Cities m100Cities); // deletes compeletly
    }
}
