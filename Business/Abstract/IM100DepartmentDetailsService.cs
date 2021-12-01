using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100DepartmentDetailsService
    {
        IDataResult<List<M100DepartmentDetails>> GetAll();
    }
}
