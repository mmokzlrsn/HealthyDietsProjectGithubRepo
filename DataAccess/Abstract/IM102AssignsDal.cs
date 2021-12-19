using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM102AssignsDal : IEntityRepository<M102Assigns>
    {
        List<M102AssignsDto> GetM102AssignsDto();
    }
}
