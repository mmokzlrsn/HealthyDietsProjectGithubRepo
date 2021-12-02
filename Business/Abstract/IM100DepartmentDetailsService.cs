using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100DepartmentDetailsService
    {
        IDataResult<List<M100DepartmentDetails>> GetAll();
        IDataResult<M100DepartmentDetails> GetById(int m100DepartmentDetailsId); //filtered get
        IResult Add(M100DepartmentDetails m100DepartmentDetails); //adds new Data
        IResult Update(M100DepartmentDetails m100DepartmentDetails); //UPDATEs information
        IResult Delete(M100DepartmentDetails m100DepartmentDetails); // update the isDeleted
        IResult Kill(M100DepartmentDetails m100DepartmentDetails); // deletes compeletly
    }
}
