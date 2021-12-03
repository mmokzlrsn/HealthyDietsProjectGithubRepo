using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100MessageBoxManager : IM100MessageBoxService
    {
        IM100MessageBoxDal _m100MessageBoxDal;

        public M100MessageBoxManager(IM100MessageBoxDal m100MessageBoxDal)
        {
            _m100MessageBoxDal = m100MessageBoxDal;
        }

        public IResult Add(M100MessageBox m100MessageBox)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100MessageBox m100MessageBox)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100MessageBox>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100MessageBox> GetById(int m100MessageBoxId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100MessageBox m100MessageBox)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100MessageBox m100MessageBox)
        {
            throw new NotImplementedException();
        }
    }
}
