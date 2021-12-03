using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100IpListService
    {
        IDataResult<List<M100IpList>> GetAll();
        IDataResult<M100IpList> GetById(int m100IpListId);
        IResult Add(M100IpList m100IpList);
        IResult Update(M100IpList m100IpList);
        IResult Delete(M100IpList m100IpList);
        IResult Kill(M100IpList m100IpList);


    }
}
