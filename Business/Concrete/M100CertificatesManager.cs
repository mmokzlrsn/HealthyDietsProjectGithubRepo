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

        public IDataResult<List<M100Certificates>> GetAll()
        {
            return new SuccessDataResult<List<M100Certificates>>(_m100CertificatesDal.GetAll());
        }
    }
}
