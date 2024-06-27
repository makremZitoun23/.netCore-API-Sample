using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
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

        [HttpPost]
        public string CreateShort(int id)
        {
            return $"Update shorts ID : {id}";

        }


        /*[HttpPut]
        [Route("/shirts/{id}")]*/
        [HttpPut("{id}")]
        public string UpdateShirt(int id) {
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
