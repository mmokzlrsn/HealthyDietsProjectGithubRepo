using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100DocumentContainerDal : EfEntityRepositoryBase<M100DocumentContainer, DatabaseContext>, IM100DocumentContainerDal
    {
        public List<M100DocumentContainerDto> GetM100DocumentContainerDtos()
        {
            throw new NotImplementedException();
        }
    }
}
