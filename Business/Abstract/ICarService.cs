using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        // GetAll, GetById, Insert, Update, Delete.

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        Car GetById(int id);
        List<CarDetailDto> GetCarDetails();
        List<Car> GetAll();
    }
}
