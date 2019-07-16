
using PaisesWEBAPI.Entities;

namespace PaisesWEBAPI.Services
{
   public interface ITravelerRepository
    {
        Traveler GetTraveler(string id);
        void AddTraveler(Traveler newTraveler);
        bool TravelerExists(string travelerId);
        bool Save();
    }
}
