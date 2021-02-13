using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate != null && rental.ReturnDate>rental.RentDate)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalInfosAdded);
            }
            return new ErrorResult(Messages.RentalInfosInvalid);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Rental>>(Messages.RentalInfosListed);
        }

        public IDataResult<Rental> GetCarsByRentalId(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.RentId == id),Messages.RentalListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalInfosUpdated);
        }
    }
}
