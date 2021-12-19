using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; //importing linq is important

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100AddressBookDal : EfEntityRepositoryBase<M100AddressBook, DatabaseContext>, IM100AddressBookDal
    {
        public List<M100AddressBookDto> GetAddressBookDto()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from a in context.M100AddressBook
                             join c in context.M100Cities
                             on a.CityId equals c.CitiesId
                             select new M100AddressBookDto { AddressBookId = a.AddressBookId, CityId = c.CitiesId };
                return result.ToList();
            }
        }
    }
}
