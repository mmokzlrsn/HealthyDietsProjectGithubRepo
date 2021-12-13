﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM102RepeatsTypeDal: EfEntityRepositoryBase<M102RepeatsType, DatabaseContext>, IM102RepeatsTypeDal
    {
    }
}
