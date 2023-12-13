using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetShirtById(int id)
        {
            if(id <= 0)
            {
                return BadRequest();
            }
            var shirt = ShirtRepository.GetShirtById(id);
            if (shirt == null)
                return NotFound();

            return Ok(shirt);
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
