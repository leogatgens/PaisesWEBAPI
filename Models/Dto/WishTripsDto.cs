using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaisesWEBAPI.Models.Dto
{
    public class WishTripsDto
    {

        public int IdTrip { get; set; }
        public int IdPais { get; set; }
        public string Name { get; set; }
        public string UrlFlag { get; set; }

        public DateTime annoDeLaVisita { get; set; }

    }
}
