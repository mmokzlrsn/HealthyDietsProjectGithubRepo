using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM102ClientDocumentsDal:IEntityRepository<M102ClientDocuments>
    {
        List<M102ClientDocumentsDto> GetM102ClientDocumentsDto();
    }
}
