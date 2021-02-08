using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUICar_
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var cars in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(cars.CarId+ " "+ cars.Description+" " +cars.DailyPrice);
            }
            Console.ReadKey();
        }
    }
}
