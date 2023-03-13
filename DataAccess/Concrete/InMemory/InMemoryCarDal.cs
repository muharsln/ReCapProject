using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100, ModelYear = "2019", Description = "Sportif araç"},
                new Car {Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 200, ModelYear = "2022", Description = "Geniş araç"},
                new Car {Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 150, ModelYear = "2022", Description = "Az yakıt yakan araç"},
                new Car {Id = 4, BrandId = 3, ColorId = 3, DailyPrice = 120, ModelYear = "2022", Description = "Aile için araç"},
                new Car {Id = 5, BrandId = 3, ColorId = 2, DailyPrice = 300, ModelYear = "2023", Description = "Son model araç"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.First(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.First(p => p.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.First(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
