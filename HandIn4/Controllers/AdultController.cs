using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HandIn4.Database;
using HandIn4.Database.Context;
using HandIn4.Models;
using Microsoft.AspNetCore.Mvc;

namespace HandIn4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultController:ControllerBase
    {
        private DAOAdults adults;

        public AdultController(DAOAdults adults)
        {
            this.adults = adults;
        }
        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> getAdults(
            [FromQuery] string firstName,
            [FromQuery] string lastName,
            [FromQuery] string jobTitle,
            [FromQuery] string hairColor,
            [FromQuery] string eyeColor,
            [FromQuery] string sex,
            [FromQuery] int? age,
            [FromQuery] int? AdultID
        )
        {
            try
            {
                 IList<Adult> adultList = await adults.getAdults(firstName,lastName,jobTitle,hairColor,eyeColor,sex,
                     age,AdultID);

                return Ok(adultList);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> addAdults([FromBody]Adult adult)
        {
            try
            {
                await adults.addAdult(adult);
                return Created($"/{adult.Id}", adult);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{Id:int}")]
        public async Task<ActionResult> deleteAdult([FromRoute] int Id)
        {
            try
            {
                await adults.deleteAdult(Id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
    }
}