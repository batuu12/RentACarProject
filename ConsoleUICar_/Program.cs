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
            foreach (var cars in carManager.GetProductDetails())
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3}" ,cars.CarId,cars.BrandId,cars.ColorName,cars.Description);
            }
            Console.ReadKey();
        }
    }
}
