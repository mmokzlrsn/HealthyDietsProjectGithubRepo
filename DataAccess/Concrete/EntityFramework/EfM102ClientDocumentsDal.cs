using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM102ClientDocumentsDal : EfEntityRepositoryBase<M102ClientDocuments, DatabaseContext>, IM102ClientDocumentsDal
    {
        public List<M102ClientDocumentsDto> GetM102ClientDocumentsDto()
        {
            throw new NotImplementedException();
        }
    }
}
