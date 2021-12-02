using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100EmployeeService
    {
        IDataResult<List<M100Employee>> GetAll();
        IDataResult<M100Employee> GetById(int m100EmployeeId);
        IResult Add(M100Employee m100Employee);
        IResult Update(M100Employee m100Employee);
        IResult Delete(M100Employee m100Employee);
        IResult Kill(M100Employee m100Employee);

    }
}
