using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100UniversitiesDal : EfEntityRepositoryBase<M100Universities, DatabaseContext>, IM100UniversitiesDal
    {
        public List<M100UniversitiesDto> GetM100UniversitiesDto()
        {
            throw new NotImplementedException();
        }
    }
}
