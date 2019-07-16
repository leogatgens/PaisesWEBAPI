using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace PaisesWEBAPI.Controllers
{
    [Route("api/game/paises")]
    [ApiController]
    public class GameController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            List<Pais> paisesEuropa = ObtieneEuropePaises();
            List<Pais> paisesAmerica = ObtienePaisesDeAmerica();

            List<Pais> finalList = paisesEuropa.Concat(paisesAmerica).ToList();
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
                    FlagUrl = "http://localhost:3000/img/germany-flag-button-square-xs.png",

                },
                new Pais
                {
                    Id = 91,
                    Name = "España",
                    Continent = "Europe",
                    FlagUrl = "http://localhost:3000/img/spain-flag-button-square-xs.png",

                },
                new Pais
                {
                    Id = 92,
                    Name = "Portugal",
                    Continent = "Europe",
                    FlagUrl = "http://localhost:3000/img/portugal-flag-button-square-xs.png",

                },
                 new Pais
                {
                    Id = 93,
                    Name = "Francia",
                    Continent = "Europe",
                    FlagUrl = "http://localhost:3000/img/france-flag-button-square-xs.png",

                },
                  new Pais
                {
                    Id = 94,
                    Name = "Russia",
                    Continent = "Europe",
                    FlagUrl = "http://localhost:3000/img/russia-flag-button-square-xs.png",

                },
                   new Pais
                {
                    Id = 95,
                    Name = "Inglaterra",
                    Continent = "Europe",
                    FlagUrl = "http://localhost:3000/img/united-kingdom-flag-button-square-xs.png",

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
                    FlagUrl = "http://localhost:3000/img/argentina-flag-button-square-xs.png",

                },
                new Pais
                {
                    Id = 2,
                    Name = "Brazil",
                    Continent = "America",
                    FlagUrl = "http://localhost:3000/img/brazil-flag-button-square-xs.png",

                },
                new Pais
                {
                    Id = 3,
                    Name = "Costa Rica",
                    Continent = "America",
                    FlagUrl = "http://localhost:3000/img/costa-rica-flag-button-square-xs.png",

                },
                 new Pais
                {
                    Name = "Uruguay",
                    Continent = "America",
                    FlagUrl = "http://localhost:3000/img/uruguay-flag-3d-xs.png",

                },
                  new Pais
                {
                    Id = 4,
                    Name = "Paraguay",
                    Continent = "America",
                    FlagUrl = "http://localhost:3000/img/paraguay-flag-button-square-xs.png",

                },
                   new Pais
                {
                    Id = 5,
                    Name = "Colombia",
                    Continent = "America",
                    FlagUrl = "http://localhost:3000/img/colombia-flag-button-square-xs.png",

                },
                new Pais
                {
                    Id = 6,
                    Name = "Peru",
                    Continent = "America",
                    FlagUrl = "http://localhost:3000/img/notfound.png",

                },
                new Pais
                {
                    Id = 7,
                    Name = "Bolivia",
                    Continent = "America",
                    FlagUrl = "http://localhost:3000/img/notfound.png",

                },
                new Pais
                {
                    Id = 8,
                    Name = "Venezuela",
                    Continent = "America",
                    FlagUrl = "http://localhost:3000/img/notfound.png",

                }
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