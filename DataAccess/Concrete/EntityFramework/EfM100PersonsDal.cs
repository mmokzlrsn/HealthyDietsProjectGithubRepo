using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100PersonsDal : EfEntityRepositoryBase<M100Persons, DatabaseContext>, IM100PersonsDal
    {
        public List<M100PersonsDto> GetM100PersonsDto()
        {
            throw new NotImplementedException();
        }
    }
}
