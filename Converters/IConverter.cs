using PaisesWEBAPI.Entities;
using PaisesWEBAPI.Models;
using PaisesWEBAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaisesWEBAPI.Converters
{
   public  interface IConverter
    {
        Trip MapTripDtoToTrip(Models.Dto.TripForCreationDto value);
        TripDto MapTripTripDto(Trip tripFromRepo);





        Traveler MapTravelerForCreationToTravelerDto(TravelerForCreationDto traveler);
        TravelerDto TravelerRepoToTravelerUI(Traveler travelerFromRepo);

        FutureTrips MapWishListItemDtoToTrip(WishTripForCretionDto value);
        WishTripsDto WishTripToWishTripUI(FutureTrips travelerFromRepo);
    }
}
