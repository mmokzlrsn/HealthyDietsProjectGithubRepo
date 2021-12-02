using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100AllEmailAddressService
    {
        IDataResult<List<M100AllEmailAddress>> GetAll();
        IDataResult<M100AllEmailAddress> GetById(int m100AllEmailAddressId); //filtered get
        IResult Add(M100AllEmailAddress m100AllEmailAddress); //adds new Data
        IResult Update(M100AllEmailAddress m100AllEmailAddress); //UPDATEs information
        IResult Delete(M100AllEmailAddress m100AllEmailAddress); // update the isDeleted
        IResult Kill(M100AllEmailAddress m100AllEmailAddress); // deletes compeletly
    }
}
