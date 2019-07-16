
using PaisesWEBAPI.Entities;
using PaisesWEBAPI.Models.Dto;
using System.Collections.Generic;

namespace PaisesWEBAPI.Services
{
   public interface IWishListRepository
    {
        void AddWishTrip(FutureTrips NewTrip);

        void DeleteWishTrip(FutureTrips wishtripEntity);

        //Manejar WishList
        IEnumerable<WishTripsDto> ListWishList(string clientId);

        FutureTrips GetWishTrip(int IdTrip);
        bool Save();
    }
}
