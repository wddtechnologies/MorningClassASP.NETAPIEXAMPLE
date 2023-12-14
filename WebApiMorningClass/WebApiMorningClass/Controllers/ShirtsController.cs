using Microsoft.AspNetCore.Mvc;
using WebApiMorningClass.Filters;
using WebApiMorningClass.Models;
using WebApiMorningClass.Models.Repositories;

namespace WebApiMorningClass.Controllers
{
    

    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
        [HttpGet]
       public string GetShirts()
        {
            return " Reading all the shirts";
        }
        [HttpGet("{id}")]
        [Shirt_ValidateShirtIdFilter]
        public IActionResult GetShirtById(int id)
        {
            return Ok(ShirtRepository.GetShirtById(id));
        }

        [HttpPost]
        public string CreateShirt([FromForm]Shirt shirt)
        {

            return " this is creating a shirt";
         
        }
        [HttpPut ("{id}")]
        public string UpdateShirt(int id)
        {
            return $" Updating shirt by id:  {id}";
        }
        [HttpDelete("{id}")]
        public string DeleteShirt(int id)
        {
            return $" Deleting shirt by id:  {id}";
        }
    }
}
