﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
namespace Business.Abstract
{
    public interface IM100CertificatesService
    {
        IDataResult<List<M100Certificates>> GetAll();
    }
}