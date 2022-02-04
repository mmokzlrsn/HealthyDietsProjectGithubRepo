using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100StatesDal : EfEntityRepositoryBase<M100States, DatabaseContext>, IM100StatesDal
    {
        public List<M100StatesDto> GetM100StatesDto()
        {
            throw new NotImplementedException();
        }
    }
}
