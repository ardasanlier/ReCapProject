using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDetail();
            CarTest();
            BrandTest();
            Car car = new Car();
            car.CarName = "d";
            Console.WriteLine(car.CarName);
        }

        private static void CarDetail()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.BrandName);
                Console.WriteLine(car.CarName);
                Console.WriteLine(car.ColorName);
                Console.WriteLine(car.DailyPrice);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }
}
