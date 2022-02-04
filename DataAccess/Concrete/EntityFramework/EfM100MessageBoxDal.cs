using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100MessageBoxDal : EfEntityRepositoryBase<M100MessageBox, DatabaseContext>, IM100MessageBoxDal
    {
        public List<M100MessageBoxDto> GetM100MessageBoxDto()
        {
            throw new NotImplementedException();
        }
    }
}
