﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var addedColor = context.Entry(context);
                addedColor.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Color entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var deletedColor = context.Entry(context);
                deletedColor.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (RentCarContext context = new RentCarContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var updatedColor = context.Entry(context);
                updatedColor.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
