using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100AllPhoneDal : EfEntityRepositoryBase<M100AllPhone, DatabaseContext>, IM100AllPhoneDal
    {
    }
}
