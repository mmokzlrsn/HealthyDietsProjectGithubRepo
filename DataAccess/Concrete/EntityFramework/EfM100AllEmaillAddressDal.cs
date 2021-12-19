using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100AllEmaillAddressDal : EfEntityRepositoryBase<M100AllEmailAddress, DatabaseContext>, IM100AllEmailAddressDal
    {
        public List<M100AllEmailAddressDto> GetM100AllEmailAddressDto()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from a in context.M100AllEmailAddress
                             join p in context.M100Persons
                             on a.PersonId equals p.PersonsId
                             select new M100AllEmailAddressDto { AllEmailAddressId = a.AllEmailAddressId, PersonId = p.PersonsId };


                    return result.ToList();

            }
        }
    }
}
