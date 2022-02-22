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
    public class EfM100AdminDal : EfEntityRepositoryBase<M100Admin, DatabaseContext>, IM100AdminDal
    {
        public List<M100AdminDto> GetM100AdminDto()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from a in context.M100Admin
                             join p in context.M100Persons
                             on a.PersonId equals p.PersonsId
                             select new M100AdminDto 
                             { AdminId = a.AdminId, PersonId = p.PersonsId };
                return result.ToList();
            }
           
        }
    }
}
