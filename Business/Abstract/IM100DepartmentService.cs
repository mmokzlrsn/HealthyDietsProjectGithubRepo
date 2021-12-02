using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100DepartmentService 
    {
        IDataResult<List<M100Department>> GetAll();
        IDataResult<M100Department> GetById(int m100DepartmentId); //filtered get
        IResult Add(M100Department m100Department); //adds new Data
        IResult Update(M100Department m100Department); //UPDATEs information
        IResult Delete(M100Department m100Department); // update the isDeleted
        IResult Kill(M100Department m100Department); // deletes compeletly
    }
}
