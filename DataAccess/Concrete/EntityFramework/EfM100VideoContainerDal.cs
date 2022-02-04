using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100VideoContainerDal : EfEntityRepositoryBase<M100VideoContainer, DatabaseContext>, IM100VideoContainerDal
    {
        public List<M100VideoContainerDto> GetM100VideoContainerDto()
        {
            throw new NotImplementedException();
        }
    }
}
