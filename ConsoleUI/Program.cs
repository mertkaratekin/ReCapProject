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
            //CarTest();
            //BrandTest();
            //BrandTest2();
            //CarTest2();
            //CarAddTest();
            //ColorUpdateTest();
            /*CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Description +" / "+ car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
            }*/


        }

        private static void ColorUpdateTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var colors in colorManager.GetAll())
            {
                Console.WriteLine(colors.ColorName);
            }
            Color color = new Color() { ColorId = 7, ColorName = "Fushia" };
            colorManager.Update(color);

            Console.WriteLine("Düzenleme yapildi");
            foreach (var colors in colorManager.GetAll())
            {
                Console.WriteLine(colors.ColorId + " / " + colors.ColorName);
            }
        }

        private static void CarAddTest()
        {
            CarManager carManager2 = new CarManager(new EfCarDal());

            foreach (var cars in carManager2.GetAll())
            {
                Console.WriteLine(cars.Description);
            }
            Car car = new Car() { BrandId = 4, ColorId = 2, ModelYear = 2023, DailyPrice = 1250, Description = "Havalı" };

            carManager2.Add(car);

            Console.WriteLine("\nekledikten sonra:\n");

            foreach (var cars in carManager2.GetAll())
            {
                Console.WriteLine(cars.Description);
            }
        }

        private static void BrandTest2()
        {
            BrandManager brandManager2 = new BrandManager(new EfBrandDal());
            foreach (var brands in brandManager2.GetAll())
            {
                Console.WriteLine(brands.BrandName);
            }
            Brand brand = new Brand() { BrandId = 9, BrandName = "Mercedes" };

            brandManager2.Add(brand);

            Console.WriteLine("\nekledikten sonra:\n");

            foreach (var brands in brandManager2.GetAll())
            {
                Console.WriteLine(brands.BrandName);
            }


            brandManager2.Delete(brand);

            Console.WriteLine("\nsildikten sonra:\n");
            foreach (var brands in brandManager2.GetAll())
            {
                Console.WriteLine(brands.BrandName);
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