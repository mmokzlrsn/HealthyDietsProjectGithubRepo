using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100PersonsAddressesService
    {
        IDataResult<List<M100PersonsAddresses>> GetAll();
        IDataResult<M100PersonsAddresses> GetById(int m100PersonsAddressesId);
        IResult Add(M100PersonsAddresses m100PersonsAddresses);
        IResult Update(M100PersonsAddresses m100PersonsAddresses);
        IResult Delete(M100PersonsAddresses m100PersonsAddresses);
        IResult Kill(M100PersonsAddresses m100PersonsAddresses);

    }
}
