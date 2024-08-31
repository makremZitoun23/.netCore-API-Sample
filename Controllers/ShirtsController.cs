using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.Repositories;
using WebApplication1.Filters;
namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {

        public List<Shirt> shirts = new List<Shirt>()
        {

            new Shirt {ShirtId = 1 , Brand ="My Brand", Color ="Blue", Gender="Men", Size= 30 , Price= 10},
            new Shirt {ShirtId = 2 , Brand ="My Brand", Color ="Black", Gender="Men", Size= 35, Price= 12},
            new Shirt {ShirtId = 3 , Brand ="Your Brand", Color ="Pink", Gender="Women", Size= 28 , Price=8},
            new Shirt {ShirtId = 4 , Brand ="Your Brand", Color ="Yello", Gender="Women", Size= 30, Price=9}
        };

        /*[HttpGet]
        [Route("/shirts")]*/
        [HttpGet]
        public string Getshirts()
        {
            return "Reading All the shirts";
        }

        /*[HttpGet]
        [Route("/shirts/{id}")]*/
        [HttpGet("{id}/{color}")]
        public string GetshirtsByID(int id, /*[FromQuery]*/ /*[FromRoute]*/ [FromHeader(Name = "Color")] string color)
        {

            return $"Reading shord ID : {id}";

        }

        [HttpGet("{id}")]
        [Shirts_ValidationShirtIdFilter]
        public IActionResult GetshirtsByID(int id)
        {
            /*if (id < 0) 
                return BadRequest();*/
            
            //var shirts = ShirtsRepository.GetShirtById(id);
            //this.shirts.First(x => x.ShirtId == id);
            //return $"Reading shord ID : {id}";
            /*if (shirts == null)
               return NotFound();*/

              // return Ok(shirts);

            return Ok(ShirtsRepository.GetShirtById(id));
        }

        [HttpPost]
        public string CreateShort([FromBody] Shirt shirt)
        {
            return "Create Short";

        }


        /*[HttpPut]
        [Route("/shirts/{id}")]*/
        [HttpPut("{id}")]
        public string UpdateShirt(int id)
        {
            return $"Update short ID : {id}";

        }
        /*[HttpDelete]
        [Route("/shirts/{id}")]*/
        [HttpDelete("{id}")]
        public string DeleteShirt(int id)
        {
            return $"Delete short ID : {id}";

        }
    }
}
