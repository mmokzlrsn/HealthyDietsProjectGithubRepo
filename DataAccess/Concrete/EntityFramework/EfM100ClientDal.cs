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
    public class EfM100ClientDal : EfEntityRepositoryBase<M100Client, DatabaseContext>, IM100ClientDal
    {
        public List<M100ClientDto> GetM100ClientDto()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from c in context.M100Client
                             join p in context.M100Persons
                             on c.PersonId equals p.PersonsId
                             select new M100ClientDto { ClientId = c.ClientId, PersonId = p.PersonsId };

                return result.ToList();
            }
        }
    }
}
