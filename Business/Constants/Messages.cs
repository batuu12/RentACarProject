using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Arabalar Listelendi";
        public static string BrandNameInvalid;
        public static string BrandNameListed;
        public static string BrandNameDeleted;
        public static string BrandNameAdded;
        public static string BrandUpdated;
        public static string ColorIdAdded;
        public static string ColorIdNotFound;
        public static string ColorDeleted;
        public static string ColorListed;
        public static string ColorUpdated;
        public static string CompanyNameInvalid;
        public static string CustomerAdded;
        public static string CustomerDeleted;
        public static string CustomerUpdated;
        public static string CustomerListed;
        public static string RentalInfosAdded;
        public static string RentalInfosInvalid;
        public static string RentalDeleted;
        public static string RentalInfosUpdated;
        public static string RentalInfosListed;
        public static string RentalListed;
        public static string UserAdded;
        public static string UserInvalidInfos;
        public static string UserDeleted;
        public static string UserUpdated;
        public static string UsersListed;
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string CarImageLimitExceeded;
    }
}
