

using PaisesWEBAPI.Context;
using PaisesWEBAPI.Entities;
using System.Linq;

namespace PaisesWEBAPI.Services
{
    public class TravelerRepository : ITravelerRepository
    {
        private readonly TripsContext datacontext;

        public TravelerRepository(TripsContext context)
        {
            datacontext = context;


        }

        void ITravelerRepository.AddTraveler(Traveler newTraveler)
        {
            datacontext.Traveler.Add(newTraveler);

            // the repository fills the id (instead of using identity columns)

        }

        Traveler ITravelerRepository.GetTraveler(string id)
        {
            return datacontext.Traveler.FirstOrDefault(a => a.ClientId == id);
        }

        bool ITravelerRepository.Save()
        {
            return (datacontext.SaveChanges() >= 0);
        }

        bool ITravelerRepository.TravelerExists(string travelerId)
        {
            return datacontext.Traveler.Any(t => t.ClientId == travelerId);
        }
    }
}
