using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

RentalManager rentalManager = new RentalManager(new EfRentalDal());

var result = rentalManager.Add(new Rental
{
    CarId = 4,
    CustomerId = 1,
    RentDate = "20.03.2023"
});

if (result.Success)
{
    Console.WriteLine(result.Message);
}
else
{
    Console.WriteLine(result.Message);
}