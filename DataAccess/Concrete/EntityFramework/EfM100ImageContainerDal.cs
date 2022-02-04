using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100ImageContainerDal : EfEntityRepositoryBase<M100ImageContainer, DatabaseContext>, IM100ImageContainerDal
    {
        public List<M100ImageContainerDto> GetM100ImageContainerDto()
        {
            throw new NotImplementedException();
        }
    }
}
