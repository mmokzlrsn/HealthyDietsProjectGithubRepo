using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100AdminService
    {
        IDataResult<List<M100Admin>> GetAll();
        IDataResult<M100Admin> GetById(int m100AdminId); //filtered get
        IResult Add(M100Admin m100Admin); //adds new Data
        IResult Update(M100Admin m100Admin); //UPDATEs information
        IResult Delete(M100Admin m100Admin); // update the isDeleted
        IResult Kill(M100Admin m100Admin); // deletes compeletly
    }
}
