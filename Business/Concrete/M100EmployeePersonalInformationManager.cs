using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100EmployeePersonalInformationManager: IM100EmployeePersonalInformationService
    {
        IM100EmployeePersonalInformationDal _m100EmployeePersonalInformationDal;

        public M100EmployeePersonalInformationManager(IM100EmployeePersonalInformationDal m100EmployeePersonalInformationDal)
        {
            _m100EmployeePersonalInformationDal = m100EmployeePersonalInformationDal;
        }

        public IResult Add(M100EmployeePersonalInformation m100EmployeePersonalInformation)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100EmployeePersonalInformation m100EmployeePersonalInformation)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100EmployeePersonalInformation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100EmployeePersonalInformation> GetById(int m100EmployeePersonalInformationId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100EmployeePersonalInformation m100EmployeePersonalInformation)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100EmployeePersonalInformation m100EmployeePersonalInformation)
        {
            throw new NotImplementedException();
        }
    }
}
