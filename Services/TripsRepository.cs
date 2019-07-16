
using Microsoft.EntityFrameworkCore;
using PaisesWEBAPI.Context;
using PaisesWEBAPI.Entities;
using PaisesWEBAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PaisesWEBAPI.Services
{
    public class TripsRepository : ITripsRepository,IPaisesRepository,IWishListRepository
    {
        private readonly TripsContext datacontext;

        public TripsRepository(TripsContext context)
        {
            datacontext = context;



        }




        bool ITripsRepository.TripExists(int IdTrip)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TripDto> ITripsRepository.ListTrips(int travelerId)
        {



            var mytrips = datacontext.Trip.Where(x => x.TravelerId == travelerId).Include("Country")
                .Select(x => new TripDto
                {
                    IdPais = x.IdCountry,
                    AnnoDeLaVisita = x.DateVisited
               ,
                    CodigoPais = x.Country.CountryCode,
                    Pais = x.Country.Name,
                    UrlFlag = x.Country.FlagUrl
                }).OrderByDescending(f => f.AnnoDeLaVisita).ToList();

            return mytrips;
        }

        void ITripsRepository.UpdateTrip(Trip UpdatedTrip)
        {
            throw new NotImplementedException();
        }


        void ITripsRepository.AddTrip(Trip NewTrip)
        {
            datacontext.Trip.Add(NewTrip);
        }



        void ITripsRepository.DeleteTrip(Entities.Trip IdTrip)
        {
            throw new NotImplementedException();
        }



        Trip ITripsRepository.GetTrip(int IdTrip)
        {
            return datacontext.Trip.Include("Country").FirstOrDefault(x => x.Id == IdTrip);
        }
   


    
        CountryDto ITripsRepository.GetCountry(int id)
        {
            throw new NotImplementedException();
        }


        bool ITripsRepository.Save()
        {
            return (datacontext.SaveChanges() >= 0);
        }

      

        IEnumerable<CountryDto> IPaisesRepository.ListAllCountries()
        {
            return datacontext.Country.Select(c => new CountryDto
            { IdCountry = c.IdCountry, Name = c.Name, Capital = c.Capital
            , Continent = c.CountryCode, UrlFlag = c.FlagUrl }).ToList();
        }

        void IWishListRepository.AddWishTrip(FutureTrips NewTrip)
        {
            datacontext.FutureTrips.Add(NewTrip);
        }

        void IWishListRepository.DeleteWishTrip(FutureTrips wishtripEntity)
        {
            datacontext.Remove(wishtripEntity);
        }

        IEnumerable<WishTripsDto> IWishListRepository.ListWishList(string clientId)
        {
            var mytrips = datacontext.FutureTrips.Include("Country")
                 .Where(x => x.ClientId == clientId)
                 .Select(x => new WishTripsDto
                 {
                     IdTrip = x.Id,
                     Name = x.Country.Name,
                     annoDeLaVisita = x.TripDate
                 ,
                     IdPais = x.Country.IdCountry,
                     UrlFlag = x.Country.FlagUrl
                 }).ToList();

            return mytrips;
        }

        bool IWishListRepository.Save()
        {
            return (datacontext.SaveChanges() >= 0);
        }

        FutureTrips IWishListRepository.GetWishTrip(int IdTrip)
        {
            return datacontext.FutureTrips.Include("Country").FirstOrDefault(x => x.Id == IdTrip);
        }
    }
}

