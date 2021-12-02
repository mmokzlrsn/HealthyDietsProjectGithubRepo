using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100ClientService
    {
        IDataResult<List<M100Client>> GetAll();
        IDataResult<M100Client> GetById(int m100ClientId); //filtered get
        IResult Add(M100Client m100Client); //adds new Data
        IResult Update(M100Client m100Client); //UPDATEs information
        IResult Delete(M100Client m100Client); // update the isDeleted
        IResult Kill(M100Client m100Client); // deletes compeletly
    }
}
