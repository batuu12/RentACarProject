using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult AddCar(Car car, Brand brand)
        {
            if (car.DailyPrice>0 && brand.BrandName.Length>2)
            {
                return new SuccessResult(Messages.CarAdded);
            }
            return new ErrorResult(Messages.CarNameInvalid);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==03)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }

        public IDataResult<List<CarDetailsDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetProductDetails());
        }
    }
}
