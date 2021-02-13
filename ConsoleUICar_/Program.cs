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
            var result = carManager.GetAll();
            if (result.Success==true)
            {
                foreach (var x in result.Data)
                {
                    Console.WriteLine("{0} -- {1} -- {2}" ,x.CarId,x.BrandId,x.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
            Console.ReadKey();
        }
    }
}
