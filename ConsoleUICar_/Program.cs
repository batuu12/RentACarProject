using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUICar_
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.CarId+ " " +cars.DailyPrice+" "+cars.Description);
            }
            Console.ReadKey();
        }
    }
}
