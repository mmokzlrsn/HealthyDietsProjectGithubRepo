using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100EmailControlService
    {
        IDataResult<List<M100EmailControl>> GetAll();
        IDataResult<List<M100EmailControl>> GetById(int m100EmailControlId);
        IResult Add(M100EmailControl m100EmailControl);
        IResult Update(M100EmailControl m100EmailControl);
        IResult Delete(M100EmailControl m100EmailControl);
        IResult Kill(M100EmailControl m100EmailControl);

    }
}
