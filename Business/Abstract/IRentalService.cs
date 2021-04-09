﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetRentalById(int rentalId);
        IDataResult<Rental> GetRentalsByCarId(int carId);
        IDataResult<Rental> GetRentalsByCustomerId(int customerId);

        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<List<RentalDetailDto>> GetRentalDetailsByRentalId(int rentalId);
        IDataResult<List<RentalDetailDto>> GetRentalDetailsByCarId(int carId);
        IDataResult<List<RentalDetailDto>> GetRentalDetailsByCustomerId(int customerId);

        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
    }
}
