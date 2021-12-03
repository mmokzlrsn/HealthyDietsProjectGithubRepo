using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100SiteInfoManager: IM100SiteInfoService
    {
        IM100SiteInfoDal _m100SiteInfoDal;

        public M100SiteInfoManager(IM100SiteInfoDal m100SiteInfoDal)
        {
            _m100SiteInfoDal = m100SiteInfoDal;
        }

        public IResult Add(M100SiteInfo m100SiteInfo)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100SiteInfo m100SiteInfo)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100SiteInfo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100SiteInfo> GetById(int m100SiteInfoId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100SiteInfo m100SiteInfo)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100SiteInfo m100SiteInfo)
        {
            throw new NotImplementedException();
        }
    }
}
