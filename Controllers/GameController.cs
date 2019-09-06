using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace PaisesWEBAPI.Controllers
{
    [Route("api/game/paises")]
    [ApiController]
    //[Authorize]
    public class GameController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            List<Pais> paisesEuropa = ObtieneEuropePaises();
            List<Pais> paisesAmerica = ObtienePaisesDeAmerica();
            List<Pais> paisesAsia = ObtienePaisesDeAsia();

            List<Pais> finalList = paisesEuropa.Concat(paisesAmerica).Concat(paisesAsia).ToList();
            //System.Threading.Thread.Sleep(2000);
            return Ok(finalList);

        }

        private static List<Pais> ObtieneEuropePaises()
        {
            return new List<Pais>
            {
                new Pais
                {
                    Id = 90,
                    Name = "Alemania",
                    Continent = "Europe",
                    FlagUrl = "##CDN##/germany-flag-button-square-xs.png",

                },
                new Pais
                {
                    Id = 91,
                    Name = "España",
                    Continent = "Europe",
                    FlagUrl = "##CDN##/spain-flag-button-square-xs.png",

                },
                new Pais
                {
                    Id = 92,
                    Name = "Portugal",
                    Continent = "Europe",
                    FlagUrl = "##CDN##/portugal-flag-button-square-xs.png",

                },
                 new Pais
                {
                    Id = 93,
                    Name = "Francia",
                    Continent = "Europe",
                    FlagUrl = "##CDN##/france-flag-button-square-xs.png",

                },
                  new Pais
                {
                    Id = 94,
                    Name = "Russia",
                    Continent = "Europe",
                    FlagUrl = "##CDN##/russia-flag-button-square-xs.png",

                },
                   new Pais
                {
                    Id = 95,
                    Name = "Inglaterra",
                    Continent = "Europe",
                    FlagUrl = "##CDN##/united-kingdom-flag-button-square-xs.png",

                }
            };
        }
        private static List<Pais> ObtienePaisesDeAmerica()
        {
            return new List<Pais>
            {
                new Pais
                {
                    Id = 1,
                    Name = "Argentina",
                    Continent = "America",
                    FlagUrl = "##CDN##/argentina-flag-button-square-xs.png",

                },
                new Pais
                {
                    Id = 2,
                    Name = "Brazil",
                    Continent = "America",
                    FlagUrl = "##CDN##/brazil-flag-button-square-xs.png",

                },
                new Pais
                {
                    Id = 3,
                    Name = "Costa Rica",
                    Continent = "America",
                    FlagUrl = "##CDN##/costa-rica-flag-button-square-xs.png",

                },
                 new Pais
                {
                    Name = "Uruguay",
                    Continent = "America",
                    FlagUrl = "##CDN##/uruguay-flag-3d-xs.png",

                },
                  new Pais
                {
                    Id = 4,
                    Name = "Paraguay",
                    Continent = "America",
                    FlagUrl = "##CDN##/paraguay-flag-button-square-xs.png",

                },
                   new Pais
                {
                    Id = 5,
                    Name = "Colombia",
                    Continent = "America",
                    FlagUrl = "##CDN##/colombia-flag-button-square-xs.png",

                },
                new Pais
                {
                    Id = 6,
                    Name = "Peru",
                    Continent = "America",
                    FlagUrl = "##CDN##/notfound.png",

                },
                new Pais
                {
                    Id = 7,
                    Name = "Bolivia",
                    Continent = "America",
                    FlagUrl = "##CDN##/notfound.png",

                },
                new Pais
                {
                    Id = 8,
                    Name = "Venezuela",
                    Continent = "America",
                    FlagUrl = "##CDN##/notfound.png",

                }
            };
        }

        private static List<Pais> ObtienePaisesDeAsia()
        {
            return new List<Pais>
            {
                new Pais
                {
                    Id = 50,
                    Name = "China",
                    Continent = "Asia",
                    FlagUrl = "##CDN##/china-flag-button-square-xs.png",

                },
                new Pais
                {
                    Id = 51,
                    Name = "Japan",
                    Continent = "Asia",
                    FlagUrl = "##CDN##/japan-flag-button-square-xs.png",

                },
                  new Pais
                {
                    Id = 52,
                    Name = "Arabia Saudita",
                    Continent = "Asia",
                    FlagUrl = "##CDN##/notfound.png",

                },
                          new Pais
                {
                    Id = 53,
                    Name = "Corea del Sur ",
                    Continent = "Asia",
                    FlagUrl = "##CDN##/notfound.png",

                },

            };
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
public class Pais
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string FlagUrl { get; set; }
    public string Continent { get; set; }
}