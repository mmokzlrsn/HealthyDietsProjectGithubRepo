using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100NewsletterControlsDal:IEntityRepository<M100NewsletterControls>
    {
        List<M100NewsletterControlsDto> GetM100NewsletterControlsDto();
    }
}
