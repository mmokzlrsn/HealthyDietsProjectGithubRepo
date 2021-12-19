using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100AddressBookDal : IEntityRepository<M100AddressBook>
    {
        List<M100AddressBookDto> GetAddressBookDto(); //https://github.com/engindemirog/KampFinalProject/blob/master/DataAccess/Concrete/EntityFramework/EfProductDal.cs
        //https://youtu.be/Hgqqoycoh9c?t=10096
    }
}
