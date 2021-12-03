using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100TimeZoneDal: EfEntityRepositoryBase<M100TimeZone, DatabaseContext>, IM100TimeZoneDal
    {
    }
}
