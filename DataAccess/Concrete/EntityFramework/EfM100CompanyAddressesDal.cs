using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100CompanyAddressesDal : EfEntityRepositoryBase<M100CompanyAddresses,DatabaseContext>, IM100CompanyAddressesDal
    {
    }
}
