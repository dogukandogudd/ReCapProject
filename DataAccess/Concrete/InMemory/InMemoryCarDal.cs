﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=3,ModelYear=2021,DailyPrice=193,Description="Renault Clio"},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2020,DailyPrice=99,Description="Renault Symbol"},
                new Car{Id=3,BrandId=2,ColorId=0,ModelYear=2019,DailyPrice=156,Description="Fiat Egea"},
                new Car{Id=4,BrandId=3,ColorId=2,ModelYear=2018,DailyPrice=154,Description="Volkswagen Caddy Exclusive"},
                new Car{Id=5,BrandId=4,ColorId=1,ModelYear=2017,DailyPrice=199,Description="Skoda Octavia"}

                //0beyaz 1siyah 2gri 3kırmızı
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(x => x.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(x => x.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}