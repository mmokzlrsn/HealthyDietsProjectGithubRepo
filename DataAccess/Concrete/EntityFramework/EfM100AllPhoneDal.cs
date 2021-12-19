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
    public class EfM100AllPhoneDal : EfEntityRepositoryBase<M100AllPhone, DatabaseContext>, IM100AllPhoneDal
    {
        public List<M100AllPhoneDto> GetM100AllPhoneDto()
        {
            using(DatabaseContext context = new DatabaseContext())
            {
                var result = from a in context.M100AllPhone
                             join p in context.M100Persons
                             on a.PersonId equals p.PersonsId
                             select new M100AllPhoneDto { AllPhoneId = a.AllPhoneId , PersonId = p.PersonsId };

                return result.ToList();
            }
        }
    }
}
