using PaisesWEBAPI.Entities;
using PaisesWEBAPI.Models;
using PaisesWEBAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaisesWEBAPI.Converters
{
    public class Converter : IConverter
    {
        Traveler IConverter.MapTravelerForCreationToTravelerDto(TravelerForCreationDto traveler)
        {
            Traveler nuevoTraveler = new Traveler()
            {
                DateOfBirth = DateTime.Now,
                Name = traveler.FirstName,
                LastName = traveler.LastName,
                Genre = "N",
                ClientId = traveler.ClientId




            };
            return nuevoTraveler;
        }

        Trip IConverter.MapTripDtoToTrip(TripForCreationDto value)
        {
            Trip nuevoViaje = new Trip()
            {
                DateVisited = value.VisitedDate,
                IdCountry = value.IdPais,
                TravelerId = 10



            };
            return nuevoViaje;
        }

        TripDto IConverter.MapTripTripDto(Trip tripFromRepo)
        {
            TripDto viajeRealizado = new TripDto()
            {
                AnnoDeLaVisita = tripFromRepo.DateVisited,
                IdPais = tripFromRepo.IdCountry,
                CodigoPais = tripFromRepo.Country.CountryCode,
                Pais = tripFromRepo.Country.Name,
                UrlFlag = tripFromRepo.Country.FlagUrl



            };
            return viajeRealizado;
        }

        TravelerDto IConverter.TravelerRepoToTravelerUI(Traveler travelerFromRepo)
        {
            TravelerDto nuevoTraveler = new TravelerDto()
            {
                Age = travelerFromRepo.DateOfBirth.Year,
                Name = string.Concat(travelerFromRepo.Name, " ", travelerFromRepo.LastName),
                Genre = travelerFromRepo.Genre,
                Id = travelerFromRepo.Id


            };
            return nuevoTraveler;
        }

        FutureTrips IConverter.MapWishListItemDtoToTrip(WishTripForCretionDto newWishTrip)
        {
            FutureTrips nuevoWishTrip = new FutureTrips()
            {
                ClientId = newWishTrip.ClientId,
                IdCountry = newWishTrip.IdPais,
                TripDate = newWishTrip.DateTrip


            };
            return nuevoWishTrip;
        }

        WishTripsDto IConverter.WishTripToWishTripUI(FutureTrips wishTripFromRepo)
        {
            WishTripsDto nuevoWishTrip = new WishTripsDto()
            {
                IdPais = wishTripFromRepo.Id,
                Name = wishTripFromRepo.Country.Name


            };
            return nuevoWishTrip;
        }



    }
}
