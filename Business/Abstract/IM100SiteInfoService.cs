using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100SiteInfoService
    {
        IDataResult<List<M100SiteInfo>> GetAll();
        IDataResult<M100SiteInfo> GetById(int m100SiteInfoId);
        IResult Add(M100SiteInfo m100SiteInfo);
        IResult Update(M100SiteInfo m100SiteInfo);
        IResult Delete(M100SiteInfo m100SiteInfo);
        IResult Kill(M100SiteInfo m100SiteInfo);


        
    }
}
