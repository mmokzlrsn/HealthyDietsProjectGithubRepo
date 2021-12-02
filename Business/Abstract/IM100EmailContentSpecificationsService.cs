using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100EmailContentSpecificationsService
    {
        IDataResult<List<M100EmailContentSpecifications>> GetAll();
        IDataResult<M100EmailContentSpecifications> GetById(int m100EmailContentSpecificationsId); //filtered get
        IResult Add(M100EmailContentSpecifications m100EmailContentSpecifications); //adds new Data
        IResult Update(M100EmailContentSpecifications m100EmailContentSpecifications); //UPDATEs information
        IResult Delete(M100EmailContentSpecifications m100EmailContentSpecifications); // update the isDeleted
        IResult Kill(M100EmailContentSpecifications m100EmailContentSpecifications); // deletes compeletly
    }
}
