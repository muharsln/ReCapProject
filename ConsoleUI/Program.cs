using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

Car car = new Car { BrandId = 2, ColorId = 1, ModelYear = "2017", DailyPrice = 0, Description = "Yeni Eklenen Araç 2" };

Console.ReadKey();

carManager.Add(car);