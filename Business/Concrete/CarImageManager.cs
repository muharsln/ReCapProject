using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helper.FileTool;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile file, CarImage carImage)
        {
            var result = BusinessRules.Run(AddedCarImageLong(carImage.Id));
            if (result != null)
            {
                return result;
            }
            carImage.ImagesPath = _fileHelper.Upload(file, Paths.ImageUploadPath);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            _fileHelper.Delete(Paths.ImageUploadPath + carImage.ImagesPath);
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            carImage.ImagesPath = _fileHelper.Update(file, Paths.ImageUploadPath + carImage.ImagesPath, Paths.ImageUploadPath);
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        [CacheAspect]
        public IDataResult<List<CarImage>> GetCarId(int id)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(p => p.CarId == id));
        }

        private IResult AddedCarImageLong(int id)
        {
            var result = _carImageDal.GetAll(p => p.CarId == id);
            if (result.Count >= 5)
            {
                return new ErrorResult("Bir arabanın en fazla 5 adet resmi olabilir");
            }
            return new SuccessResult();
        }


        [CacheAspect]
        public IDataResult<CarImage> GetImageById(int imgId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(p => p.Id == imgId));
        }
    }
}