using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100ExcepitonLogsDal : EfEntityRepositoryBase<M100ExceptionLogs, DatabaseContext>, IM100ExceptionLogsDal
    {
        public List<M100ExceptionLogsDto> GetM100ExceptionLogsDto()
        {
            throw new NotImplementedException();
        }
    }
}
