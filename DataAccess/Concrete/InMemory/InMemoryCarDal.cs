using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=100,Description="Mazda",ModelYear=1996 },
                new Car{CarId=2,BrandId=2,ColorId=3,DailyPrice=150,Description="BMW",ModelYear=2000 },
                new Car{CarId=3,BrandId=2,ColorId=2,DailyPrice=200,Description="Mercedes",ModelYear=2007 }
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
           Car carToDelete = _car.SingleOrDefault(p => p.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(p => p.BrandId == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
        }
    }
}
