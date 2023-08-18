using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //DATA CREATION
            //CreateDataOfColorAndBrands();
            //CreateDataOfCars();

            //------------------------------------------------

            //CarTest();
            //UpdateCarTest();
            //CarDeleteTest();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("Id:{0}   Car: {1}     Color: {2}   Details: {3}    Daily Price: {4}",car.CarId,car.BrandName,car.ColorName,car.Description,car.DailyPrice);
            }
        }

        private static void CarDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { CarId = 12 });
        }

        private static void UpdateCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { CarId = 7, BrandId = 1, ColorId = 15, DailyPrice = 2300, ModelYear = 2011, Description = "2011 Sky Blue BMW" });
        }

        private static void CreateDataOfCars()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarId = 1, BrandId = 1, ColorId = 3, DailyPrice = 1500, ModelYear = 2003, Description = "2003 Green BMW" });
            carManager.Add(new Car { CarId = 2, BrandId = 6, ColorId = 1, DailyPrice = 2000, ModelYear = 1998, Description = "1998 Red Citroen" });
            carManager.Add(new Car { CarId = 3, BrandId = 10, ColorId = 22, DailyPrice = 1700, ModelYear = 2011, Description = "2011 Salmon Porsche" });
            carManager.Add(new Car { CarId = 4, BrandId = 5, ColorId = 5, DailyPrice = 1000, ModelYear = 2018, Description = "2018 Purple Renault" });
            carManager.Add(new Car { CarId = 5, BrandId = 13, ColorId = 9, DailyPrice = 2300, ModelYear = 2013, Description = "2013 Black Ford" });
            carManager.Add(new Car { CarId = 6, BrandId = 11, ColorId = 10, DailyPrice = 1750, ModelYear = 2020, Description = "2020 White Tesla" });
            carManager.Add(new Car { CarId = 7, BrandId = 19, ColorId = 1, DailyPrice = 2300, ModelYear = 2011, Description = "2011 Red Chevrolet" });
            carManager.Add(new Car { CarId = 8, BrandId = 1, ColorId = 9, DailyPrice = 1700, ModelYear = 2019, Description = "2019 Black BMW" });
            carManager.Add(new Car { CarId = 9, BrandId = 15, ColorId = 23, DailyPrice = 1000, ModelYear = 2015, Description = "2015 Crimson Honda" });
            carManager.Add(new Car { CarId = 10, BrandId = 8, ColorId = 10, DailyPrice = 900, ModelYear = 2011, Description = "2011 White Fiat" });
            carManager.Add(new Car { CarId = 11, BrandId = 7, ColorId = 15, DailyPrice = 1300, ModelYear = 2015, Description = "2015 Sky Blue Peugeot" });
            carManager.Add(new Car { CarId = 12, BrandId = 9, ColorId = 4, DailyPrice = 1700, ModelYear = 2019, Description = "2019 Yellow Volvo" });
        }

        private static void CreateDataOfColorAndBrands()
        {
            Console.WriteLine("----------------Adding Brands----------------");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 1, BrandName = "BMW" });
            brandManager.Add(new Brand { BrandId = 2, BrandName = "Audi" });
            brandManager.Add(new Brand { BrandId = 3, BrandName = "Mercedes" });
            brandManager.Add(new Brand { BrandId = 4, BrandName = "Volkswagen" });
            brandManager.Add(new Brand { BrandId = 5, BrandName = "Renault" });
            brandManager.Add(new Brand { BrandId = 6, BrandName = "Citroen" });
            brandManager.Add(new Brand { BrandId = 7, BrandName = "Peugeot" });
            brandManager.Add(new Brand { BrandId = 8, BrandName = "Fiat" });
            brandManager.Add(new Brand { BrandId = 9, BrandName = "Volvo" });
            brandManager.Add(new Brand { BrandId = 10, BrandName = "Porsche" });
            brandManager.Add(new Brand { BrandId = 11, BrandName = "Tesla" });
            brandManager.Add(new Brand { BrandId = 12, BrandName = "Toyota" });
            brandManager.Add(new Brand { BrandId = 13, BrandName = "Ford" });
            brandManager.Add(new Brand { BrandId = 14, BrandName = "Nissan" });
            brandManager.Add(new Brand { BrandId = 15, BrandName = "Honda" });
            brandManager.Add(new Brand { BrandId = 16, BrandName = "Lotus" });
            brandManager.Add(new Brand { BrandId = 17, BrandName = "Subaru" });
            brandManager.Add(new Brand { BrandId = 18, BrandName = "Bentley" });
            brandManager.Add(new Brand { BrandId = 19, BrandName = "Chevrolet" });
            brandManager.Add(new Brand { BrandId = 20, BrandName = "Koenigsegg" });
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------Adding Colors----------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorId = 1, ColorName = "Red" });
            colorManager.Add(new Color { ColorId = 2, ColorName = "Blue" });
            colorManager.Add(new Color { ColorId = 3, ColorName = "Green" });
            colorManager.Add(new Color { ColorId = 4, ColorName = "Yellow" });
            colorManager.Add(new Color { ColorId = 5, ColorName = "Purple" });
            colorManager.Add(new Color { ColorId = 6, ColorName = "Pink" });
            colorManager.Add(new Color { ColorId = 7, ColorName = "Orange" });
            colorManager.Add(new Color { ColorId = 8, ColorName = "Brown" });
            colorManager.Add(new Color { ColorId = 9, ColorName = "Black" });
            colorManager.Add(new Color { ColorId = 10, ColorName = "White" });
            colorManager.Add(new Color { ColorId = 11, ColorName = "Gray" });
            colorManager.Add(new Color { ColorId = 12, ColorName = "Gold" });
            colorManager.Add(new Color { ColorId = 13, ColorName = "Silver" });
            colorManager.Add(new Color { ColorId = 14, ColorName = "Navy Blue" });
            colorManager.Add(new Color { ColorId = 15, ColorName = "Sky Blue" });
            colorManager.Add(new Color { ColorId = 16, ColorName = "Lime Green" });
            colorManager.Add(new Color { ColorId = 17, ColorName = "Teal" });
            colorManager.Add(new Color { ColorId = 18, ColorName = "İndigo" });
            colorManager.Add(new Color { ColorId = 19, ColorName = "Magenta" });
            colorManager.Add(new Color { ColorId = 20, ColorName = "Violet" });
            colorManager.Add(new Color { ColorId = 21, ColorName = "Khaki" });
            colorManager.Add(new Color { ColorId = 22, ColorName = "Salmon" });
            colorManager.Add(new Color { ColorId = 23, ColorName = "Crimson" });
            colorManager.Add(new Color { ColorId = 24, ColorName = "Lavender" });
            colorManager.Add(new Color { ColorId = 25, ColorName = "Plum" });
            colorManager.Add(new Color { ColorId = 26, ColorName = "Blue Violet" });
            colorManager.Add(new Color { ColorId = 27, ColorName = "Olive" });
            colorManager.Add(new Color { ColorId = 28, ColorName = "Cyan" });
            colorManager.Add(new Color { ColorId = 29, ColorName = "Maroon" });
            colorManager.Add(new Color { ColorId = 30, ColorName = "Beige" });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("{0} : {1}", car.CarId, car.ModelYear);
            }
        }
    }
}