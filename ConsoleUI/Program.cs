using Business.Concrete;
using DataAccess.Concrete.Entityframework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carmanager = new CarManager(new EfCarDal());
            //Update(carmanager);
            //Delete(carmanager);
            //GetById(carmanager);
            //Add(carmanager);
            GetAll(carmanager);

        }

        private static void Update(CarManager carmanager)
        {
            Car car3 = carmanager.GetById(1);
            car3.Description = "Update edildi";
            carmanager.Update(car3);
            Console.WriteLine(car3.Id + "/" + car3.Description);
        }

        private static void Delete(CarManager carmanager)
        {
            Car car2 = carmanager.GetById(2);
            carmanager.Delete(car2);
            foreach (var car in carmanager.GetAll())
            {
                Console.WriteLine(car.Id + "/" + car.Description);
            }
        }

        private static void GetById(CarManager carmanager)
        {
            Car car1 = carmanager.GetById(3);

            Console.WriteLine(car1.Id + "/" + car1.Description);
        }

        private static void Add(CarManager carmanager)
        {
            carmanager.Add(new Car
            {
                //Id = 5,
                BrandId = 4,
                ColorId = 5,
                DailyPrice = 950,
                ModelYear = 2005,
                Description = "Eklenen araba"
            });
            foreach (var car in carmanager.GetAll())
            {
                Console.WriteLine(car.BrandId + "/" + car.Description);
            }
        }

        private static void GetAll(CarManager carmanager)
        {
            foreach (var car in carmanager.GetAll())
            {
                Console.WriteLine(car.Id + "/" + car.Description);
            }
        }
    }
}
