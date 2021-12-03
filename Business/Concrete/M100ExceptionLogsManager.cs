using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100ExceptionLogsManager : IM100ExceptionLogsService
    {
        IM100ExceptionLogsDal _m100ExceptionLogsDal;

        public M100ExceptionLogsManager(IM100ExceptionLogsDal m100ExceptionLogsDal)
        {
            _m100ExceptionLogsDal = m100ExceptionLogsDal;
        }

        public IResult Add(M100ExceptionLogs m100ExceptionLogs)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100ExceptionLogs m100ExceptionLogs)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100ExceptionLogs>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100ExceptionLogs> GetById(int m100ExceptionLogsId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100ExceptionLogs m100ExceptionLogs)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100ExceptionLogs m100ExceptionLogs)
        {
            throw new NotImplementedException();
        }
    }
}
