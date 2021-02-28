﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal )
        {
            _carDal = carDal;

        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll(); 
        }

        public void Add(Car car)
        {
            if (car.Description.Length>2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Unsuccesful entry");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public Car GetCarsByBrandId(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        public Car GetCarsByColorId(int id)
        {
            return _carDal.Get(c => c.ColorId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public Car GetCarsById(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }
    }
}
