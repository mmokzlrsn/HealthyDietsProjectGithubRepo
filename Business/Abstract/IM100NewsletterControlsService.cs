using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100NewsletterControlsService
    {
        IDataResult<List<M100NewsletterControls>> GetAll();
        IDataResult<M100NewsletterControls> GetById(int m100NewsletterControlsId);
        IResult Add(M100NewsletterControls m100NewsletterControls);
        IResult Update(M100NewsletterControls m100NewsletterControls);
        IResult Delete(M100NewsletterControls m100NewsletterControls);
        IResult Kill(M100NewsletterControls m100NewsletterControls);
    }
}
