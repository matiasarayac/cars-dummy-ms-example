using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarsDummyService.Models;
using Microsoft.AspNetCore.Http;

namespace CarsDummyService.Controllers
{
    [Route("")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("cars/")]
        [ProducesResponseType(typeof(Cars), StatusCodes.Status200OK)]        
        public IActionResult GetCars(string userId)
        {

            List<Cars> listaAutos = new List<Cars>();
            Cars car1 = new Cars();
            Cars car2 = new Cars();
            Cars car3 = new Cars();

            car1.model = "audi";
            car2.model = "citroen";
            car3.model = "volskwagen";

            car1.color = "blanco";
            car2.color = "negro";
            car3.color = "rojo";

            listaAutos.Add(car1);
            listaAutos.Add(car2);
            listaAutos.Add(car3);


            return Ok(listaAutos);
        }       
    }
}
