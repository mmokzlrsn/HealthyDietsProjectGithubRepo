using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100CategoriesService
    {
        IDataResult<List<M100Categories>> GetAll();
    }
}
