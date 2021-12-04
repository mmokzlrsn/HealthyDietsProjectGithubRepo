using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M102ClientDocumentsManager: IM102ClientDocumentsService
    {
        IM102ClientDocumentsDal _m102ClientDocumentsDal;

        public M102ClientDocumentsManager(IM102ClientDocumentsDal m102ClientDocumentsDal)
        {
            _m102ClientDocumentsDal = m102ClientDocumentsDal;
        }

        public IResult Add(M102ClientDocuments m102ClientDocuments)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M102ClientDocuments m102ClientDocuments)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M102ClientDocuments>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M102ClientDocuments> GetById(int m102ClientDocumentsId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M102ClientDocuments m102ClientDocuments)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M102ClientDocuments m102ClientDocuments)
        {
            throw new NotImplementedException();
        }
    }
}
