﻿using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IDataResult<Rental> GetById(int id);
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}