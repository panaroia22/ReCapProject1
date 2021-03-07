using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : IColorDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {

                new Car{ Id =1, BrandId=2, ColorId=3, DailyPrice=200, Description="Fiat Egea", ModelYear=2020},
                new Car{ Id =2, BrandId=2, ColorId=7, DailyPrice=200, Description="Fiat Fiorino", ModelYear=2018},
                new Car{ Id =3, BrandId=1, ColorId=8, DailyPrice=200, Description="Bmw 320i", ModelYear=2016},
                new Car{ Id =4, BrandId=3, ColorId=5, DailyPrice=200, Description="Wolkswogan Passat", ModelYear=2009},
                new Car{ Id =5, BrandId=8, ColorId=2, DailyPrice=200, Description="Ford Mondeo", ModelYear=2017},
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public void Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
