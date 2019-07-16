
using Microsoft.AspNetCore.Mvc;
using PaisesWEBAPI.Converters;
using PaisesWEBAPI.Models.Dto;
using PaisesWEBAPI.Services;
using System.Collections.Generic;

namespace PaisesWEBAPI.Controllers
{
    [Route("api/travelers/{travelerId}/trips")]
    public class TripController : Controller
    {
        private readonly ITripsRepository TripsRepository;
        private readonly ITravelerRepository travelerRepository;
        private readonly IConverter CustomMapper;

        public TripController(ITripsRepository LibraryRepository, IConverter convertidorModelos, ITravelerRepository LibraryTravelerRepository)
        {
            TripsRepository = LibraryRepository;
            CustomMapper = convertidorModelos;
            travelerRepository = LibraryTravelerRepository;
        }


        [HttpGet("{id}", Name = "GetTrip")]
        public IActionResult GetWishTrip(int id)
        {
            var TripFromRepo = TripsRepository.GetTrip(id);



            if (TripFromRepo == null)
            {
                return NotFound();
            }

            TripDto TripDone = CustomMapper.MapTripTripDto(TripFromRepo);

            return Ok(TripDone);
        }



        [HttpGet]
        public ActionResult<IEnumerable<string>> ListTrips(string travelerId)
        {

            if (!travelerRepository.TravelerExists(travelerId))
            {
                return NotFound();
            }

            var usuario = travelerRepository.GetTraveler(travelerId);
            var tripsFromRepo = TripsRepository.ListTrips(usuario.Id);
            return Ok(tripsFromRepo); //Retonar un codigo 200



        }

        [HttpPost]
        public IActionResult CreateTrip([FromBody] TripForCreationDto newTrip)
        {
            if (newTrip == null)
            {
                return BadRequest();
            }
            
            if (!ModelState.IsValid)
            {
                return new UnprocessableEntityObjectResult(ModelState);
            }
            var tripEntity = CustomMapper.MapTripDtoToTrip(newTrip);

            TripsRepository.AddTrip(tripEntity);

            if (!TripsRepository.Save())
            {
                throw new System.Exception("Creating an wish trip failed on save.");
            }

            // var newTripToReturn = CustomMapper.MapTripTripDto(tripEntity);

            return CreatedAtRoute("GetTrip",
               new { id = tripEntity.Id }, null
             );


        }
    }
}