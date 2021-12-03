using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100VerificationsManager: IM100VerificationsService
    {
        IM100VerificationsDal _m100VerificationsDal;

        public M100VerificationsManager(IM100VerificationsDal m100VerificationsDal)
        {
            _m100VerificationsDal = m100VerificationsDal;
        }

        public IResult Add(M100Verifications m100Verifications)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100Verifications m100Verifications)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100Verifications>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100Verifications> GetById(int m100VerificationsId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100Verifications m100Verifications)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100Verifications m100Verifications)
        {
            throw new NotImplementedException();
        }
    }
}
