using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IM100EmployeePersonalInformationDal:IEntityRepository<M100EmployeePersonalInformation>
    {
        List<M100EmployeePersonalInformationDto> GetM100EmployeePersonalInformationDto();
    }
}
