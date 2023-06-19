using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
namespace ConsoleUI
{
    public class Program
    {
        private static void Main(string[] args)
        {
            /*CarName, BrandName, ColorName, DailyPrice*/
            //CarTest();
            //BrandTest();
            //CarTest2();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Description +" / "+ car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
            }
        }

        private static void CarTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Description + " / " + car.BrandName);
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

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.BrandId);
            }

            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(car.ColorId);
            }
        }
    }
}