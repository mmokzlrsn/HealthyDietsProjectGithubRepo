using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100MessageBoxDal:IEntityRepository<M100MessageBox>
    {
        List<M100MessageBoxDto> GetM100MessageBoxDto();
    }
}
