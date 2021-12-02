using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100ArticleService
    {
        IDataResult<List<M100Article>> GetAll();
        IDataResult<M100Article> GetById(int m100ArticleId); //filtered get
        IResult Add(M100Article m100Article); //adds new Data
        IResult Update(M100Article m100Article); //UPDATEs information
        IResult Delete(M100Article m100Article); // update the isDeleted
        IResult Kill(M100Article m100Article); // deletes compeletly
    }
}
