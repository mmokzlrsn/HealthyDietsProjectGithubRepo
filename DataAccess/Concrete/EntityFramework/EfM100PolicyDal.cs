using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100PolicyDal : EfEntityRepositoryBase<M100Policy, DatabaseContext>, IM100PolicyDal
    {
        public List<M100PersonsDto> GetM100PersonsDto()
        {
            throw new NotImplementedException();
        }
    }
}
