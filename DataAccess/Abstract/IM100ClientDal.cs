using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IM100ClientDal : IEntityRepository<M100Client>
    {
        List<M100ClientDto> GetM100ClientDto();
    }
}
