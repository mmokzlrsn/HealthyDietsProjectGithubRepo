using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
namespace Business.Abstract
{
    public interface IM100AllPhoneService
    {
        IDataResult<List<M100AllPhone>> GetAll();
        IDataResult<M100AddressBook> GetById(int m100AddressBookId); //filtered get
        IResult Add(M100AddressBook m100AddressBook); //adds new Data
        IResult Update(M100AddressBook m100AddressBook); //UPDATEs information
        IResult Delete(M100AddressBook m100AddressBook); // update the isDeleted
        IResult Kill(M100AddressBook m100AddressBook); // deletes compeletly
    }
}
