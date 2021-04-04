using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car is added";
        public static string InvalidEntry = "Invalid Entry";
        public static string CarDeleted = "Car is deleted";
        public static string CarUpdated = "Car is updated";
        public static string BrandAdded = "Brand is added";
        public static string ColorDeleted = "Color is deleted";
        public static string ColorUpdated = "Color is updated";
        public static string UserAdded = "User is added";
        public static string UserDeleted = "User is deleted";
        public static string CustomerAdded = "Customer is added";
        public static string SystemBuilding = "System is building";
        public static string NotReturned = "The car is not returned yet";
        public static string SuccessfulRent = "Renting is successful";
        public static string ImageDeleted = "Image is deleted";
        public static string ImageAdded = "Image is added";
        public static string CannotAdd = "Image limit is full";
        public static string ImageNotExist = "Image does not exist";
        public static string CarNotExists = "Car does not exist";

        public static string AuthorizationDenied = "Authorization is denied";
        public static string  UserRegistered = "User is registered";
        public static string UserNotFound = "User couldnt found";
        public static string PasswordError = "Wrong password";
        public static string SuccessfulLogin = "Logined successfully";
        public static string UserAlreadyExists = "The user is already exist";
        public static string AccessTokenCreated = "Access token is created";
    }
}
