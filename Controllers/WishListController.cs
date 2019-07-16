
using Microsoft.AspNetCore.Mvc;
using PaisesWEBAPI.Converters;
using PaisesWEBAPI.Models.Dto;
using PaisesWEBAPI.Services;
using System.Collections.Generic;

namespace PaisesWEBAPI.Controllers
{
    [Route("api/travelers/{travelerId}/wishlists")]
    [ApiController]
    public class WishListController : Controller
    {

        private readonly IWishListRepository TripsRepository;
        private readonly ITravelerRepository travelerRepository;
        private readonly IConverter CustomMapper;

        public WishListController(IWishListRepository LibraryRepository, IConverter convertidorModelos, ITravelerRepository LibraryTravelerRepository)
        {
            TripsRepository = LibraryRepository;
            CustomMapper = convertidorModelos;
            travelerRepository = LibraryTravelerRepository;
        }

        [HttpPost]
        public IActionResult AddWishListItem([FromBody] WishTripForCretionDto wishtrip)
        {
            if (wishtrip == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return new UnprocessableEntityObjectResult(ModelState);
            }
            var wishtripEntity = CustomMapper.MapWishListItemDtoToTrip(wishtrip);

            TripsRepository.AddWishTrip(wishtripEntity);

            if (!TripsRepository.Save())
            {
                throw new System.Exception("Creating an wish trip failed on save.");
            }

            return CreatedAtRoute("GetWishItem",
               new { id = wishtripEntity.Id }, null);

        }




        [HttpGet]
        public ActionResult<IEnumerable<string>> ListTripsWishList(string travelerId)
        {

            if (!travelerRepository.TravelerExists(travelerId))
            {
                return NotFound();
            }
            //var usuario = travelerRepository.GetTraveler(travelerId);
            var tripsFromRepo = TripsRepository.ListWishList(travelerId);
            return Ok(tripsFromRepo); //Retonar un codigo 200
        }



        [HttpGet("{id}", Name = "GetWishItem")]
        public IActionResult GetWishTrip(int id)
        {
            var wishTripFromRepo = TripsRepository.GetWishTrip(id);



            if (wishTripFromRepo == null)
            {
                return NotFound();
            }

            WishTripsDto wishTrip = CustomMapper.WishTripToWishTripUI(wishTripFromRepo);

            return Ok(wishTrip);
        }
        [HttpDelete("{idWishTrip}")]
        public IActionResult DeleteWishTripForTraveler( string travelerId, int idWishTrip)
        {

            if (!travelerRepository.TravelerExists(travelerId))
            {
                return NotFound();
            }

            var wishTripFromRepo = TripsRepository.GetWishTrip(idWishTrip);

            if (wishTripFromRepo == null)
            {
                return NotFound();
            }


            TripsRepository.DeleteWishTrip(wishTripFromRepo);

            if (!TripsRepository.Save())
            {
                throw new System.Exception("Error deleting wished trip.");
            }


            return NoContent();

        }



    }
}