using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100FAQService
    {
        IDataResult<List<M100FAQ>> GetAll();
        IDataResult<M100FAQ> GetById(int m100FAQId);
        IResult Add(M100FAQ m100FAQ);
        IResult Update(M100FAQ m100FAQ);
        IResult Delete(M100FAQ m100FAQ);
        IResult Kill(M100FAQ m100FAQ);

    }
}
