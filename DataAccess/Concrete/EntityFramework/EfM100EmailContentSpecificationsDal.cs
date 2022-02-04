using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100EmailContentSpecificationsDal : EfEntityRepositoryBase<M100EmailContentSpecifications, DatabaseContext>, IM100EmailContentSpecificationsDal
    {
        public List<M100EmailContentSpecificationsDto> GetM100EmailContentSpecificationsDto()
        {
            throw new NotImplementedException();
        }
    }
}
            