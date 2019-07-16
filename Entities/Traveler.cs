using System;
using System.ComponentModel.DataAnnotations;

namespace PaisesWEBAPI.Entities
{
    public class Traveler
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string ClientId { get; set; }
    }
}
