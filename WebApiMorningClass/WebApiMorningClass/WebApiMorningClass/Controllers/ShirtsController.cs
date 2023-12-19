﻿using Microsoft.AspNetCore.Mvc;
using WebApiMorningClass.Filters;
using WebApiMorningClass.Filters.ActionFilters;
using WebApiMorningClass.Filters.ExceptionFilters;
using WebApiMorningClass.Models;
using WebApiMorningClass.Models.Repositories;

namespace WebApiMorningClass.Controllers
{
    

    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetShirts()
        {
            return Ok(ShirtRepository.GetShirts());
        }
        [HttpGet("{id}")]
        [Shirt_ValidateShirtIdFilter]
        public IActionResult GetShirtById(int id)
        {
            return Ok(ShirtRepository.GetShirtById(id));
        }

        [HttpPost]
        [Shirt_ValidateCreateShirtFilter]
        public IActionResult CreateShirt([FromForm]Shirt shirt)
        {
            //if (shirt == null) return BadRequest()
           // var existingShirt = ShirtRepository.GetShirtByProperties(shirt.Brand, shirt.Gender, shirt.Color, shirt.Size);
           // if (existingShirt != null) return BadRequest();
            ShirtRepository.AddShirt(shirt);
            return CreatedAtAction(nameof(GetShirtById),
                new {id = shirt.Id},
                shirt);
         
        }
        [HttpPut ("{id}")]
        [Shirt_ValidateShirtIdFilter]
        [Shirt_ValidateUpdateShirtFilter]
        [Shirt_HandleUpdateExceptionsFilter]
        public IActionResult UpdateShirt(int id,Shirt shirt)
        {
            
           ShirtRepository.UpdateShirt(shirt);
            return NoContent();
        }
        [HttpDelete("{id}")]
        [Shirt_ValidateShirtIdFilter]
        public IActionResult DeleteShirt(int id)
        {
            var shirt = ShirtRepository.GetShirtById(id);
            ShirtRepository.DeleteShirt(id);
            return Ok(shirt);
        }
    }
}
