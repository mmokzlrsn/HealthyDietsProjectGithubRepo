using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100SocialMediaTypesDal: EfEntityRepositoryBase<M100SocialMediaTypes, DatabaseContext>, IM100SocialMediaTypesDal
    {
    }
}
