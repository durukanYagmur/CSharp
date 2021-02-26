using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{BrandId=1, CarId=1, ColorId=1, DailyPrice=200, ModelYear=2017, Description="Reno Clio"},
                new Car{BrandId=2, CarId=2, ColorId=1, DailyPrice=250, ModelYear=2019, Description="Opel Corsa"},
                new Car{BrandId=2, CarId=3, ColorId=2, DailyPrice=300, ModelYear=2020, Description="Opel Astra"},
                new Car{BrandId=1, CarId=4, ColorId=3, DailyPrice=195, ModelYear=2015, Description="Reno Megan"},
                new Car{BrandId=3, CarId=5, ColorId=2, DailyPrice=400, ModelYear=2021, Description="Jeep Rubicon"},
                new Car{BrandId=3, CarId=6, ColorId=3, DailyPrice=350, ModelYear=2021, Description="Jepp Wrangler"},
                new Car{BrandId=4, CarId=7, ColorId=4, DailyPrice=100, ModelYear=2012, Description="Pegout 206"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        List<Car> IEntityRepository<Car>.GetAll(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
