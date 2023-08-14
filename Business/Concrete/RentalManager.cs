using Business.Abstract;
using Business.Constants;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            bool isCarRented = _rentalDal.GetAll().Any(r => r.CarId == rental.CarId);
            if (isCarRented)
            {
                return new ErrorResult(Messages.CarIsAlreadyRented);
            }
            else
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.CarRented);
            }
        }

        public IDataResult<List<Rental>> CheckIfExpired()
        {
            return new ErrorDataResult<List<Rental>>(_rentalDal.GetAll(r => r.ReturnDate < DateTime.Now),"These car's return date has expired");
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalRemoved);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.RentalsListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
