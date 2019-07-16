using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaisesWEBAPI.Models.Dto
{
    public class WishTripForCretionDto
    {
        [Required]
        public int IdPais { get; set; }

        [Required]
        public DateTime DateTrip { get; set; }

        [Required]
        [MaxLength(250)]
        public string ClientId { get; set; }
    }
}
