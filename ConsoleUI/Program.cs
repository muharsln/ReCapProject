using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

//BrandTest();

CarTest();

static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

    Console.ReadKey();

    //carManager.Delete(new Car { Id = 1 });

    //carManager.Update(new Car { Id = 3, ColorId = 2 });

    //carManager.Add(new Car
    //{
    //    BrandId = 5,
    //    ColorId = 1,
    //    DailyPrice = 200,
    //    ModelYear = "1980",
    //    Description = "Eski bir tofaş"
    //});

    foreach (var item in carManager.GetCarDetails())
    {
        Console.WriteLine(item.ColorName);
    }
}

static void BrandTest()
{
    BrandManager brandManager = new BrandManager(new EfBrandDal());

    foreach (var item in brandManager.GetAll())
    {
        Console.WriteLine(item.Name);
    }
}