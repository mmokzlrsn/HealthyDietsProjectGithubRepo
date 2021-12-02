using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100CertificatesManager : IM100CertificatesService
    {
        IM100CertificatesDal _m100CertificatesDal;

        public M100CertificatesManager(IM100CertificatesDal m100CertificatesDal)
        {
            _m100CertificatesDal = m100CertificatesDal;
        }

        public IResult Add(M100Certificates m100Certificates)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100Certificates m100Certificates)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100Certificates>> GetAll()
        {
            return new SuccessDataResult<List<M100Certificates>>(_m100CertificatesDal.GetAll());
        }

        public IDataResult<M100Certificates> GetById(int m100CertificatesId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100Certificates m100Certificates)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100Certificates m100Certificates)
        {
            throw new NotImplementedException();
        }
    }
}
