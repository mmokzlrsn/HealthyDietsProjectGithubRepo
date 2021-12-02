using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100CategoriesService
    {
        IDataResult<List<M100Categories>> GetAll();
        IDataResult<M100Categories> GetById(int m100CategoriesId); //filtered get
        IResult Add(M100Categories m100Categories); //adds new Data
        IResult Update(M100Categories m100Categories); //UPDATEs information
        IResult Delete(M100Categories m100Categories); // update the isDeleted
        IResult Kill(M100Categories m100Categories); // deletes compeletly
    }
}
