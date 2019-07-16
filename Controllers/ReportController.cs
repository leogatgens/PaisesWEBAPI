
using Microsoft.AspNetCore.Mvc;
using PaisesWEBAPI.Converters;
using PaisesWEBAPI.Services;
using System.Collections.Generic;

namespace PaisesWEBAPI.Controllers
{

    [Route("api/report")]
        [ApiController]
        public class ReportController : ControllerBase
        {

            private readonly IReportesRepository TripsRepository;
            private readonly IConverter CustomMapper;




        public ReportController(IReportesRepository LibraryRepository, IConverter convertidorModelos)
            {
                TripsRepository = LibraryRepository;
                CustomMapper = convertidorModelos;

                //ObtenerDatosAPIExterno();


            }

            // GET api/values
            [HttpGet]
            public ActionResult<IEnumerable<string>> Get()
            {

                var countryFromRepo = TripsRepository.ListReportOne();
                return Ok(countryFromRepo); //Retonar un codigo 200

            }



        
    }
}