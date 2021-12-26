using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100EmailContentDal : EfEntityRepositoryBase<M100EmailContent, DatabaseContext>, IM100EmailContentDal
    {
        public List<M100EmailContentDto> GetM100EmailContentDto()
        {
            throw new NotImplementedException();
        }
    }
}
