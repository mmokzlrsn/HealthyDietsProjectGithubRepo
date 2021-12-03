using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100SocialMediaTypesService
    {
        IDataResult<List<M100SocialMediaTypes>> GetAll();
        IDataResult<M100SocialMediaTypes> GetById(int m100SocialMediaTypesId);
        IResult Add(M100SocialMediaTypes m100SocialMediaTypes);
        IResult Update(M100SocialMediaTypes m100SocialMediaTypes);
        IResult Delete(M100SocialMediaTypes m100SocialMediaTypes);
        IResult Kill(M100SocialMediaTypes m100SocialMediaTypes);
        
    }
}
