using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100CountriesDal : EfEntityRepositoryBase<M100Countries, DatabaseContext>, IM100CountriesDal
    {
        public List<M100CountriesDto> GetM100CountriesDto()
        {
            throw new NotImplementedException();
        }
    }
}
