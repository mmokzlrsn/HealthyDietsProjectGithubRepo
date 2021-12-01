﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100EmailContentService
    {
        IDataResult<List<M100EmailContent>> GetAll();
    }
}