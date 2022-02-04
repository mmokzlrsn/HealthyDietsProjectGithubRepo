using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100SocialMediaTypesDal : EfEntityRepositoryBase<M100SocialMediaTypes, DatabaseContext>, IM100SocialMediaTypesDal
    {
        public List<M100SocialMediaTypesDto> GetM100SocialMediaTypesDto()
        {
            throw new NotImplementedException();
        }
    }
}
