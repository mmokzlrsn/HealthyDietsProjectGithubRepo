using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100SocialMediaTypesDal:IEntityRepository<M100SocialMediaTypes>
    {
        List<M100SocialMediaTypesDto> GetM100SocialMediaTypesDto();
    }
}
