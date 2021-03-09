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
        internal static string MaintenanceTime = "Sistem bakımda";
        internal static string CarListed = "Arabalar Listelendi";
        internal static string BrandNameInvalid;
        internal static string BrandNameListed;
        internal static string BrandNameDeleted;
        internal static string BrandNameAdded;
        internal static string BrandUpdated;
        internal static string ColorIdAdded;
        internal static string ColorIdNotFound;
        internal static string ColorDeleted;
        internal static string ColorListed;
        internal static string ColorUpdated;
        internal static string CompanyNameInvalid;
        internal static string CustomerAdded;
        internal static string CustomerDeleted;
        internal static string CustomerUpdated;
        internal static string CustomerListed;
        internal static string RentalInfosAdded;
        internal static string RentalInfosInvalid;
        internal static string RentalDeleted;
        internal static string RentalInfosUpdated;
        internal static List<Rental> RentalInfosListed;
        internal static string RentalListed;
        internal static string UserAdded;
        internal static string UserInvalidInfos;
        internal static string UserDeleted;
        internal static string UserUpdated;
        internal static string UsersListed;
        internal static string AuthorizationDenied;
        internal static string CarImageLimitExceeded;
    }
}
