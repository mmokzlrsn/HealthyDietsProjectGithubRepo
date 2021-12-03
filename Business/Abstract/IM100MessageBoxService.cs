using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100MessageBoxService
    {
        IDataResult<List<M100MessageBox>> GetAll();
        IDataResult<M100MessageBox> GetById(int m100MessageBoxId);
        IResult Add(M100MessageBox m100MessageBox);
        IResult Update(M100MessageBox m100MessageBox);
        IResult Delete(M100MessageBox m100MessageBox);
        IResult Kill(M100MessageBox m100MessageBox);

    }
}
