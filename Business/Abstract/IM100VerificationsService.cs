using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100VerificationsService
    {
        IDataResult<List<M100Verifications>> GetAll();
        IDataResult<M100Verifications> GetById(int m100VerificationsId);
        IResult Add(M100Verifications m100Verifications);
        IResult Update(M100Verifications m100Verifications);
        IResult Delete(M100Verifications m100Verifications);
        IResult Kill(M100Verifications m100Verifications);

    }
}
