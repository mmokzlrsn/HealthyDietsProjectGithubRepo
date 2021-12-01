using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100DepartmentManager: IM100DepartmentService
    {
        IM100DepartmentDal _m100DepartmentDal;

        public M100DepartmentManager(IM100DepartmentDal m100DepartmentDal)
        {
            _m100DepartmentDal = m100DepartmentDal;
        }

        public IDataResult<List<M100Department>> GetAll()
        {
            return new SuccessDataResult<List<M100Department>>(_m100DepartmentDal.GetAll());
        }
    }
}
