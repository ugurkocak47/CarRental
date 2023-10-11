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
        public static string FirstOrLastNameShort = "Your first and last name must be at least 2 letters"; //E00009
        public static string CarIsAlreadyRented = "The car you've chosen is already rented"; //E00010
        public static string UserIdInvalid = "The user id is invalid"; //E00011
        public static string CustomerIdInvalid = "The customer id is invalid"; //E00012
        public static string RentalIdInvalid = "The rental id is invalid"; //E00013
        public static string CompanyNameShort = "Company name must be at least 2 letters"; //E00014
        public static string CarImageLimitExceeded = "This car already has the max amount of images(5 Images Max)"; //E00015
        public static string AuthorizationDenied = "Authorizaton denied"; //E00016
        public static string UserNotFound = "User not found"; //E00017
        public static string PasswordError = "Password error"; //E00018
        public static string UserAlreadyExists = "User already exists"; //E00019

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
        public static string UserAdded = "User added"; //S00015
        public static string UserDeleted = "User deleted"; //S00016
        public static string UserUpdated = "User updated"; //S00017
        public static string UsersListed = "Users are listed"; //S00018
        public static string CustomerAdded = "Customer added"; //S00019
        public static string CustomerDeleted = "Customer deleted"; //S00020
        public static string CustomerUpdated = "Customer updated"; //S00021
        public static string CustomersListed = "Customers are listed"; //S00022
        public static string RentalUpdated = "Car rental is updated"; //S00023
        public static string RentalRemoved = "Car rental is removed"; //S00024
        public static string RentalsListed = "Rentals are listed"; //S00025
        public static string CarListed = "Car listed"; //S00026
        public static string BrandListed = "Brand listed"; //S00027
        public static string ColorListed = "Color listed"; //S00028
        public static string UserListed = "User listed"; //S00029
        public static string CustomerListed = "Customer listed"; //S00030
        public static string RentalListed = "Rental listed"; //S00031
        public static string CarImageAdded = "Car image added"; //S00032
        public static string CarImageUpdated = "Car image updated"; //S00033
        public static string CarImageDeleted = "Car image deleted"; //S00034
        public static string CarImagesListed = "Car images are listed"; //S00035
        public static string CarImageListed = "Car image listed"; //S00036
        public static string UserRegistered = "User registered"; //S00037
        public static string SuccessfulLogin = "Login successful"; //S00038
        public static string AccessTokenCreated = "Access token created"; //S00039
    }
    }

