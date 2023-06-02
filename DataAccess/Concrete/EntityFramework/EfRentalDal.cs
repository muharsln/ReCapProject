using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from rental in context.Rentals
                             join customer in context.Customers
                             on rental.CustomerId equals customer.Id
                             join car in context.Cars
                             on rental.CarId equals car.Id
                             select new RentalDetailDto
                             {
                                 Id = rental.Id,
                                 CarName = car.Description,
                                 CustomerName = customer.CompanyName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate,
                             };
                return result.ToList();
            }
        }
    }
}