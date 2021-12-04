using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M102AssignsManager: IM102AssignsService
    {
        IM102AssignsDal _m102AssignsDal;

        public M102AssignsManager(IM102AssignsDal m102AssignsDal)
        {
            _m102AssignsDal = m102AssignsDal;
        }

        public IResult Add(M102Assigns m102Assigns)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M102Assigns m102Assigns)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M102Assigns>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M102Assigns> GetById(int m102AssignsId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M102Assigns m102Assigns)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M102Assigns m102Assigns)
        {
            throw new NotImplementedException();
        }
    }
}
