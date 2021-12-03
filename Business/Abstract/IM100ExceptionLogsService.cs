using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100ExceptionLogsService
    {
        IDataResult<List<M100ExceptionLogs>> GetAll();
        IDataResult<M100ExceptionLogs> GetById(int m100ExceptionLogsId);
        IResult Add(M100ExceptionLogs m100ExceptionLogs);
        IResult Update(M100ExceptionLogs m100ExceptionLogs);
        IResult Delete(M100ExceptionLogs m100ExceptionLogs);
        IResult Kill(M100ExceptionLogs m100ExceptionLogs);

    }
}
