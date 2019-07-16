
using PaisesWEBAPI.Entities;
using PaisesWEBAPI.Models.Dto;
using System.Collections.Generic;

namespace PaisesWEBAPI.Services
{
    public interface ITripsRepository
    {
        IEnumerable<TripDto> ListTrips(int travelerId);
        Trip GetTrip(int IdTrip);

        void AddTrip(Trip NewTrip);
        void DeleteTrip(Trip IdTrip);
        void UpdateTrip(Trip UpdatedTrip);
        bool TripExists(int IdTrip);





     
        

        
        bool Save();
    
        CountryDto GetCountry(int id);
        
    }
}
