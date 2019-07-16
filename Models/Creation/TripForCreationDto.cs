using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaisesWEBAPI.Models.Dto
{
    public class TripForCreationDto
    {
        [Required]
        public int IdPais { get; set; }
        [Required]
        public DateTime VisitedDate { get; set; }
        [Required]
        public string ClientId { get; set; }
    }
}
