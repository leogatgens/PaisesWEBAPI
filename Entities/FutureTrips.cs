using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaisesWEBAPI.Entities
{
    public class FutureTrips
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IdCountry { get; set; }

        public Country Country { get; set; }


        [Required]
        [MaxLength(250)]
        public string ClientId { get; set; }


        [Required]
        public DateTime TripDate { get; set; }
    }
}
