using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IM100CountriesService 
    {
        IDataResult<List<M100Countries>> GetAll();
        IDataResult<M100Countries> GetById(int m100CountriesId); //filtered get
        IResult Add(M100Countries m100Countries); //adds new Data
        IResult Update(M100Countries m100Countries); //UPDATEs information
        IResult Delete(M100Countries m100Countries); // update the isDeleted
        IResult Kill(M100Countries m100Countries); // deletes compeletly
    }
}
