using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Core.CrossCuttingConcerns.Validation;
using Core.Aspects.Autofac.Validation;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Performance;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult AddCar(Car car, Brand brand)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }
        [PerformanceAspect(5)]
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            return null;
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==03)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            _carDal.GetAll();
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
