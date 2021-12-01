using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IM100EmployeeDal : IEntityRepository<M100Employee>
    {
    }
}
