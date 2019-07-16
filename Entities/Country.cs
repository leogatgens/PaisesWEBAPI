using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaisesWEBAPI.Entities
{
    public class Country
    {

        [Key]
        public int IdCountry { get; set; }

        [Required]
        public string CountryCode { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        public string Code { get; set; }

        [Required]
        public string FlagUrl { get; set; }

        [Required]
        public string Capital { get; set; }
    }
}
