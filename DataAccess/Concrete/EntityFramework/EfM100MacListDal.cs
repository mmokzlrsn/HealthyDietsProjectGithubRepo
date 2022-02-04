﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100MacListDal : EfEntityRepositoryBase<M100MacList, DatabaseContext>, IM100MacListDal
    {
        public List<M100MacListDto> GetM100MacListDto()
        {
            throw new NotImplementedException();
        }
    }
}
