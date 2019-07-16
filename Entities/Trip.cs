using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaisesWEBAPI.Entities
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IdCountry { get; set; }

        public Country Country { get; set; }

        [Required]
        public DateTime DateVisited { get; set; }

        [Required]
        public int TravelerId { get; set; }
    }
}
