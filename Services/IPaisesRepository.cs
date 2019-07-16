using PaisesWEBAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaisesWEBAPI.Services
{
   public interface IPaisesRepository
    {
        IEnumerable<CountryDto> ListAllCountries();
    }
}
