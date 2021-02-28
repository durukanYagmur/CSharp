using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Car car1 = new Car { CarId = 6, BrandId = 2, ColorId = 1, DailyPrice = 196, ModelYear = 2018, Description = "Mercedes" };
            Car car2 = new Car { CarId = 7, BrandId = 3, ColorId = 2, DailyPrice = 235, ModelYear = 2019, Description = "Auidi" };
            Car car3 = new Car { CarId = 8, BrandId = 3, ColorId = 3, DailyPrice = 543, ModelYear = 2021, Description = "Audi" };
            Car car4 = new Car { CarId = 9, BrandId = 1, ColorId = 3, DailyPrice = 287, ModelYear = 2020, Description = "Jeep" };

            Brand brand = new Brand { BrandId = 6, BrandName = "Ferrari" };

            Color color = new Color { ColorId = 5, ColorName = "Purple" };


            CarDetailsTest(carManager);

            //brandManager.Add(brand);

            foreach (var brando in brandManager.GetAll())
            {
                Console.WriteLine(brando.BrandId + " " + brando.BrandName);
            }
            Console.WriteLine();


            //colorManager.Add(color);

            foreach (var caro in colorManager.GetAll())
            {
                Console.WriteLine(caro.ColorId + " " + caro.ColorName);
                
            }
            Console.WriteLine();

            Console.WriteLine(carManager.GetCarsById(1).Description);
            Console.WriteLine(brandManager.GetById(2).BrandName);
            Console.WriteLine(colorManager.GetById(3).ColorName);

            
        }

        private static void CarDetailsTest(CarManager carManager)
        {
            Console.WriteLine("CarName----------BrandName----------ColorName----------DailyPrice");

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "       " + car.BrandName + "          " + car.ColorName + "           " + car.DailyPrice);

            }
            Console.WriteLine();
        }
    }
}
