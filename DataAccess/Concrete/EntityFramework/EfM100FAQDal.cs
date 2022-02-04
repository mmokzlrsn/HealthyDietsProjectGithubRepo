using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100FAQDal : EfEntityRepositoryBase<M100FAQ, DatabaseContext>, IM100FAQDal
    {
        public List<M100FAQDto> GetM100FAQDto()
        {
            throw new NotImplementedException();
        }
    }
}
