using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100ClientService
    {
        IDataResult<List<M100Client>> GetAll();
    }
}
