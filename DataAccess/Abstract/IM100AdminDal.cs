using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100AdminDal : IEntityRepository<M100Admin>
    {
        List<M100AdminDto> GetM100AdminDto();
    }
}
