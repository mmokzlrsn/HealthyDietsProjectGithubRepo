using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100CategoriesDal : EfEntityRepositoryBase<M100Categories, DatabaseContext>, IM100CategoriesDal
    {
        public List<M100CategoriesDto> GetM100CategoriesDto()
        {
            throw new NotImplementedException(); //parentıd?
        }
    }
}
