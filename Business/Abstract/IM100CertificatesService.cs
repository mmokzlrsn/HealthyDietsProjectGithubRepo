using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
namespace Business.Abstract
{
    public interface IM100CertificatesService
    {
        IDataResult<List<M100Certificates>> GetAll();
        IDataResult<M100Certificates> GetById(int m100CertificatesId); //filtered get
        IResult Add(M100Certificates m100Certificates); //adds new Data
        IResult Update(M100Certificates m100Certificates); //UPDATEs information
        IResult Delete(M100Certificates m100Certificates); // update the isDeleted
        IResult Kill(M100Certificates m100Certificates); // deletes compeletly
    }
}
