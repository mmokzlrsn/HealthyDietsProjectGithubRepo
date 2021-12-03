using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100SocialMediaTypesManager: IM100SocialMediaTypesService
    {
        IM100SocialMediaTypesDal _m100SocialMediaTypesDal;

        public M100SocialMediaTypesManager(IM100SocialMediaTypesDal m100SocialMediaTypesDal)
        {
            _m100SocialMediaTypesDal = m100SocialMediaTypesDal;
        }

        public IResult Add(M100SocialMediaTypes m100SocialMediaTypes)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100SocialMediaTypes m100SocialMediaTypes)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100SocialMediaTypes>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100SocialMediaTypes> GetById(int m100SocialMediaTypesId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100SocialMediaTypes m100SocialMediaTypes)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100SocialMediaTypes m100SocialMediaTypes)
        {
            throw new NotImplementedException();
        }
    }
}
