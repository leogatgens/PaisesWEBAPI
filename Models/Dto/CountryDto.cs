using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaisesWEBAPI.Models.Dto
{
    public class CountryDto
    {
        public int IdCountry { get; set; }

        public string Name { get; set; }

        public string Continent { get; set; }

        public string Capital { get; set; }

        public string UrlFlag { get; set; }
    }
}
