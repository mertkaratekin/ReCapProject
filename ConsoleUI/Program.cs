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
            //RentalAdd();
            //CustomerList();
            //CustomerAdd();
            //UserList();
            //UserAdd();
            //CarDtoTest();
            //RentalUpdate();
          
        }

        private static void RentalUpdate()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Update(new Rental() { CarId = 1, CustomerId = 2, RentDate = DateTime.Now });
            Console.WriteLine(rentalManager.GetRentalsById(4).Data.ReturnDate);
        }

        private static void CarDtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var cars in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("Araç : {0} Marka : {1} Renk : {2}", cars.Description, cars.BrandName, cars.ColorName);
            }
            Console.WriteLine(carManager.GetCarDetails().Success);
        }

        private static void UserList()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }
        }

        private static void CustomerList()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }

        private static void RentalAdd()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental() { CarId = 1, CustomerId = 2, RentDate = DateTime.Now });
        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User() { FirstName = "Beray", LastName = "Kaya", Email = "beray@mail.com", Password = "123" });
            userManager.Add(new User() { FirstName = "Aslı", LastName = "Kaftancıoğlu", Email = "aslı@mail.com", Password = "123" });
            userManager.Add(new User() { FirstName = "Kemal", LastName = "Erdoğan", Email = "kemal@mail.com", Password = "123" });
            userManager.Add(new User() { FirstName = "Ahmet", LastName = "Öztrak", Email = "oztrk@mail.com", Password = "123" });
            userManager.Add(new User() { FirstName = "Faik", LastName = "Özcan", Email = "faik@mail.com", Password = "123" });
        }

        private static void CustomerAdd()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer() { UserId = 1, CompanyName = "Mert Yazılım " });
            customerManager.Add(new Customer() { UserId = 2, CompanyName = "Shell Akaryakıt" });
            customerManager.Add(new Customer() { UserId = 3, CompanyName = "Mrt Danişmanlık" });
            customerManager.Add(new Customer() { UserId = 4, CompanyName = "Lenovo" });
        }
    }
}