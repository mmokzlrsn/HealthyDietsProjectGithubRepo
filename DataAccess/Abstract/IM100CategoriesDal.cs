using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100CategoriesDal:IEntityRepository<M100Categories>
    {
        List<M100CategoriesDto> GetM100CategoriesDto();
    }
}
