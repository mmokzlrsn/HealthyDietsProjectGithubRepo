﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM102WhoListDal : EfEntityRepositoryBase<M102WhoList, DatabaseContext>, IM102WhoListDal
    {
        public List<M102WhoListDto> GetM102WhoListDto()
        {
            throw new NotImplementedException();
        }
    }
}
