using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}

Console.WriteLine("----------İkinci Kod--------");
Console.WriteLine(carManager.GetById(1).ModelYear);