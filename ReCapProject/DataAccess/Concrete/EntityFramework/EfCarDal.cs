using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                if (entity.Description.Length > 2 && entity.DailyPrice > 0)
                {
                    var addedCar = context.Entry(context);
                    addedCar.State = EntityState.Added;
                    context.SaveChanges();
                }
                else
                    Console.WriteLine("Unsuccesfull");
            }
        }

        public void Delete(Car entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var deletedCar = context.Entry(context);
                deletedCar.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using(RentCarContext context = new RentCarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using(RentCarContext context = new RentCarContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var updatedCar = context.Entry(context);
                updatedCar.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
