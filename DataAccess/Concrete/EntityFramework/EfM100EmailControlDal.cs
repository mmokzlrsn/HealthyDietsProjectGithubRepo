using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    class EfM100EmailControlDal : EfEntityRepositoryBase<M100EmailControl, DatabaseContext>, IM100EmailControlDal
    {
        public List<M100EmailControlDto> GetM100EmailControlDto()
        {
            throw new NotImplementedException();
        }
    }
}
