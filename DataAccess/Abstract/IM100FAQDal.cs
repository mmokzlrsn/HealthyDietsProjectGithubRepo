using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100FAQDal:IEntityRepository<M100FAQ>
    {
        List<M100FAQDto> GetM100FAQDto();
    }
}
