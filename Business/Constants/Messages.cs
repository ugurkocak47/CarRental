using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Error
        public static string CarNameShortToAdd = "Car name you provided is too short to be added"; //E00001
        public static string NoAvaliableCar = "There is no available cars to list"; //E00002
        public static string CarIdInvalid = "The car id is invalid"; //E00003
        public static string BrandIdInvalid = "The brand id is invalid"; //E00004
        public static string ColorIdInvalid = "The color id is invalid "; //E00005
        public static string SystemMaintenance = "System is in maintenance"; //E00006
        public static string BrandNameShortToAdd = "The brand name you provided is too short to be added"; //E00007
        public static string ColorNameShortToAdd = "The color name you provided is too short to be added"; //E00008





        //Success
        public static string AvailableCarsListed = "Avaliable cars are listed"; //S00001
        public static string CarRented = "Car has been rented"; //S00002
        public static string CarAdded = "Car added"; //S00003
        public static string CarUpdated = "Car updated"; //S00004 
        public static string CarDeleted = "Car deleted"; //S00005
        public static string CarDetailsListed = "Car details listed"; //S00006
        public static string BrandsListed = "Brands are listed"; //S00007
        public static string BrandAdded = "Brand added"; //S00008
        public static string BrandUpdated = "Brand updated"; //S00009
        public static string BrandDeleted = "Brand deleted"; //S00010
        public static string ColorsListed = "Colors are listed"; //S00011
        public static string ColorAdded = "Color added"; //S00012
        public static string ColorUpdated = "Color updated"; //S00013
        public static string ColorDeleted = "Color deleted"; //S00014
 
    }
}
