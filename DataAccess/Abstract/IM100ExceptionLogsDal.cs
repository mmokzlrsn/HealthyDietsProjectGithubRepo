using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100ExceptionLogsDal:IEntityRepository<M100ExceptionLogs>
    {
        List<M100ExceptionLogsDto> GetM100ExceptionLogsDto();
    }
}
