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
    public class EfM100CitiesDal : EfEntityRepositoryBase<M100Cities, DatabaseContext>, IM100CitiesDal
    {
        public List<M100CitiesDto> GetM100CitiesDto()
        {
            using( DatabaseContext context = new DatabaseContext())
            {
                var result = from c in context.M100Cities
                             join s in context.M100States
                             on c.StateId equals s.StatesId
                             select new M100CitiesDto { CitiesId = c.CitiesId, StateId = s.StatesId };

                return result.ToList();


            }
        }
    }
}
