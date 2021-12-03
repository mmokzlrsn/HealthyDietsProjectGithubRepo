using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100ExcepitonLogsDal : EfEntityRepositoryBase<M100ExceptionLogs,DatabaseContext>, IM100ExceptionLogsDal
    {
    }
}
