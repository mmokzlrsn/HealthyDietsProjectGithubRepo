using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100PolicyDal: EfEntityRepositoryBase<M100Policy, DatabaseContext>, IM100PolicyDal
    {
    }
}
