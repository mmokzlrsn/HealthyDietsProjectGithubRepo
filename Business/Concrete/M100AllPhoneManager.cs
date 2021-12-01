using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class M100AllPhoneManager : IM100AllPhoneService
    {
        IM100AllPhoneDal _m100AllPhoneDal;

        public M100AllPhoneManager(IM100AllPhoneDal m100AllPhoneDal)
        {
            _m100AllPhoneDal = m100AllPhoneDal;
        }

         
        IDataResult<List<M100AllPhone>> IM100AllPhoneService.GetAll()
        {
            return new SuccessDataResult<List<M100AllPhone>>(_m100AllPhoneDal.GetAll());
        }
    }
}
