using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserManager userManager = new UserManager(new EfUsersDal());

            


            ////userManager.Add(new User {  Id=1, FirstName = "ilyas", LastName = " Tekin", Email = " ilyas@gmail.com", Password = "12345" });

            //foreach (var us in userManager.GetAll().Data)
            //{
            //    Console.WriteLine(us.FirstName);
            //}


            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            foreach (var car in result.Data)
            {
                Console.WriteLine("Araç Model "+ ":"+ car.Description +
                                    "\n Araç Model yılı"+":"+ car.ModelYear);
            }
        }


        
    }
}
