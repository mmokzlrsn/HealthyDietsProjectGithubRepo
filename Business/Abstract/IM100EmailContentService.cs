using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100EmailContentService
    {
        IDataResult<List<M100EmailContent>> GetAll();
        IDataResult<M100EmailContent> GetById(int m100EmailContentId); //filtered get
        IResult Add(M100EmailContent m100EmailContent); //adds new Data
        IResult Update(M100EmailContent m100EmailContent); //UPDATEs information
        IResult Delete(M100EmailContent m100EmailContent); // update the isDeleted
        IResult Kill(M100EmailContent m100EmailContent); // deletes compeletly
    }
}
