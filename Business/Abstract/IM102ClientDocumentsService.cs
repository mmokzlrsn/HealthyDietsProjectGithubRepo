using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM102ClientDocumentsService
    {
        IDataResult<List<M102ClientDocuments>> GetAll();
        IDataResult<M102ClientDocuments> GetById(int m102ClientDocumentsId);
        IResult Add(M102ClientDocuments m102ClientDocuments);
        IResult Update(M102ClientDocuments m102ClientDocuments);
        IResult Delete(M102ClientDocuments m102ClientDocuments);
        IResult Kill(M102ClientDocuments m102ClientDocuments);
    }
}
