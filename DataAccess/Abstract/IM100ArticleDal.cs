using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100ArticleDal:IEntityRepository<M100Article>
    {
        List<M100ArticleDto> GetM100ArticleDto();
    }
}
