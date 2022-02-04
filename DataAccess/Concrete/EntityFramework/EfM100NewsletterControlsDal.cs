using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100NewsletterControlsDal : EfEntityRepositoryBase<M100NewsletterControls, DatabaseContext>, IM100NewsletterControlsDal
    {
        public List<M100NewsletterControlsDto> GetM100NewsletterControlsDto()
        {
            throw new NotImplementedException();
        }
    }
}
