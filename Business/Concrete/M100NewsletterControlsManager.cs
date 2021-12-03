using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100NewsletterControlsManager: IM100NewsletterControlsService
    {
        IM100NewsletterControlsDal _m100NewsletterControls;

        public M100NewsletterControlsManager(IM100NewsletterControlsDal m100NewsletterControls)
        {
            _m100NewsletterControls = m100NewsletterControls;
        }

        public IResult Add(M100NewsletterControls m100NewsletterControls)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(M100NewsletterControls m100NewsletterControls)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<M100NewsletterControls>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<M100NewsletterControls> GetById(int m100NewsletterControlsId)
        {
            throw new NotImplementedException();
        }

        public IResult Kill(M100NewsletterControls m100NewsletterControls)
        {
            throw new NotImplementedException();
        }

        public IResult Update(M100NewsletterControls m100NewsletterControls)
        {
            throw new NotImplementedException();
        }
    }
}
