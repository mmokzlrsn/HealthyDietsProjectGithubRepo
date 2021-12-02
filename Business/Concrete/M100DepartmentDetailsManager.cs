using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100DepartmentDetailsManager: IM100DepartmentDetailsService
    {
        IM100DepartmentDetailsDal _m100DepartmentDetailsDal;

        public M100DepartmentDetailsManager(IM100DepartmentDetailsDal m100DepartmentDetailsDal)
        {
            _m100DepartmentDetailsDal = m100DepartmentDetailsDal;
        }

        public IResult Add(M100DepartmentDetails m100DepartmentDetails)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100DepartmentDetails m100DepartmentDetails)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100DepartmentDetails>> GetAll()
        {
            return new SuccessDataResult<List<M100DepartmentDetails>>(_m100DepartmentDetailsDal.GetAll());
        }

        public IDataResult<M100DepartmentDetails> GetById(int m100DepartmentDetailsId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100DepartmentDetails m100DepartmentDetails)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100DepartmentDetails m100DepartmentDetails)
        {
            throw new NotImplementedException();
        }
    }
}
