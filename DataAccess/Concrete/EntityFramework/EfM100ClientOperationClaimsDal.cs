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
    public class EfM100ClientOperationClaimsDal : EfEntityRepositoryBase<M100ClientOperationClaims, DatabaseContext>, IM100ClientOperationClaimsDal
    {
        public List<M100ClientOperationClaimsDto> GetM100ClientOperationClaimsDto()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from c in context.M100ClientOperationClaims
                             join p in context.M100Persons
                             on c.PersonId equals p.PersonsId
                             select new M100ClientOperationClaimsDto 
                             { 
                                 ClientOperationClaimsIp = c.ClientOperationClaimsIp,
                                 PersonId = p.PersonsId 
                             };

                return result.ToList();

                    /*
        public int ClientOperationClaimsIp { get; set; }
        public int PersonId { get; set; }
        public int OperationId { get; set; }
        public int WhoAuthId { get; set; }
                      */

            }
        }
    }
}
