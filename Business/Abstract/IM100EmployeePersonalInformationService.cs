using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100EmployeePersonalInformationService
    {
        IDataResult<List<M100EmployeePersonalInformation>> GetAll();
        IDataResult<M100EmployeePersonalInformation> GetById(int m100EmployeePersonalInformationId);
        IResult Add(M100EmployeePersonalInformation m100EmployeePersonalInformation);
        IResult Update(M100EmployeePersonalInformation m100EmployeePersonalInformation);
        IResult Delete(M100EmployeePersonalInformation m100EmployeePersonalInformation);
        IResult Kill(M100EmployeePersonalInformation m100EmployeePersonalInformation);
    }
}
