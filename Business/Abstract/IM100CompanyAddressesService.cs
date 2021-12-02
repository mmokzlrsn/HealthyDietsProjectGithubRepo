using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100CompanyAddressesService
    {
        IDataResult<List<M100CompanyAddresses>> GetAll();
        IDataResult<M100CompanyAddresses> GetById(int m100CompanyAddressesId); //filtered get
        IResult Add(M100CompanyAddresses m100CompanyAddresses); //adds new Data
        IResult Update(M100CompanyAddresses m100CompanyAddresses); //UPDATEs information
        IResult Delete(M100CompanyAddresses m100CompanyAddresses); // update the isDeleted
        IResult Kill(M100CompanyAddresses m100CompanyAddresses); // deletes compeletly
    }
}
