using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100DepartmentDal : EfEntityRepositoryBase<M100Department, DatabaseContext>, IM100DepartmentDal
    {
        public List<M100DepartmentDto> GetM100DepartmentDto()
        {
            throw new NotImplementedException();
        }
    }
}
