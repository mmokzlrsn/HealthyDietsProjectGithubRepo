using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM102KcalListDal: EfEntityRepositoryBase<M102KcalList, DatabaseContext>, IM102KcalListDal
    {
    }
}
