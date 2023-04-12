using Core.Utilities.Result;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file, CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);
        IDataResult<List<CarImage>> GetCarId(int id);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetImageById(int carId);
    }
}