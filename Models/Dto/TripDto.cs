using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaisesWEBAPI.Models.Dto
{
    public class TripDto
    {
        public int IdPais { get; set; }
        public string Pais { get; set; }

        public string UrlFlag { get; set; }

        public string CodigoPais { get; set; }

        public DateTime AnnoDeLaVisita { get; set; }
    }
}
