using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM102KcalListDal:IEntityRepository<M102KcalList>
    {
        List<M102KcalListDto> GetM102KcalListDto();
    }
}
