using Business.Abstract;
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

        public void AddCar(Car car, Brand brand)
        {
            if (car.DailyPrice>0 && brand.BrandName.Length>2)
            {
                Console.WriteLine("Ekle");
            }
            else
            {
                Console.WriteLine("Hatalı Giriş");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p=>p.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public List<CarDetailsDto> GetProductDetails()
        {
            return _carDal.GetProductDetails();
        }
    }
}
