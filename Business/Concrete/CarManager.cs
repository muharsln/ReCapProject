﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine(car.ModelYear + " model araba veritabanına eklendi");
            }
            else
            {
                Console.WriteLine("Arabanın günlük kiralama fiyatı 0 dan yüksek olmalıdır.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(car.Id + " id numaralı araba silindi");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(p => p.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(car.Id + " id numaralı araba güncellendi");
        }
    }
}