using Core.Utilites.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IResult TransactionalOperation(Car car);
        IDataResult<Car> Get(int carId);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByColorId(int colorId);
        IDataResult<List<Car>> GetByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
