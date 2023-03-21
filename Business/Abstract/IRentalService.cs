using Core.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    internal interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IDataResult<List<Rental>> GetAll();
    }
}
