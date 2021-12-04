using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM102AssignsService
    {
        IDataResult<List<M102Assigns>> GetAll();
        IDataResult<M102Assigns> GetById(int m102AssignsId);
        IResult Add(M102Assigns m102Assigns);
        IResult Update(M102Assigns m102Assigns);
        IResult Delete(M102Assigns m102Assigns);
        IResult Kill(M102Assigns m102Assigns);

    }
}
