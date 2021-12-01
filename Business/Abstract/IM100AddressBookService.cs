using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100AddressBookService
    {
        // https://youtu.be/ow-EHetuNAU?list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg    2:27:00  8. kamp 

        IDataResult<List<M100AddressBook>> GetAll();
        IDataResult<M100AddressBook> GetById(int m100AddressBookId);
        IResult Add(M100AddressBook m100AddressBook);
        IResult Update(M100AddressBook m100AddressBook);
        IResult Delete(M100AddressBook m100AddressBook); // update 
        //IResult Kill(M100AddressBook m100AddressBook);
        
    }
}
