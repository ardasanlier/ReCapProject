using DataAccess.Abstract;
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
            _cars = new List<Car> {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=20000, ModelYear=2010, Description="Economic"},
                new Car{Id=2, BrandId=2, ColorId=5, DailyPrice=35000, ModelYear=2008, Description="Technologic"},
                new Car{Id=3, BrandId=3, ColorId=3, DailyPrice=42000, ModelYear=2017, Description="Elite"},
                new Car{Id=4, BrandId=3, ColorId=2, DailyPrice=56000, ModelYear=2016, Description="Fast"},
                new Car{Id=5, BrandId=5, ColorId=4, DailyPrice=84000, ModelYear=2019, Description="Slow"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
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
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            car.BrandId = carToUpdate.BrandId;
            car.ColorId = carToUpdate.ColorId;
            car.DailyPrice = carToUpdate.DailyPrice;
            car.ModelYear = carToUpdate.ModelYear;
            car.Description = carToUpdate.Description;
        }

    }
}
