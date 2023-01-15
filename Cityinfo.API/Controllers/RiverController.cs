using Cityinfo.API.Entities;
using Cityinfo.API.Models;
using Cityinfo.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cityinfo.API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Authorize]
    [Route("api/river")]
    public class RiverController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<RiverDto>> GetRiver()
        {
           
            return Ok(RiversDataStore.Current.River);
             
        }
        [HttpGet("{id}")]

        public ActionResult<RiverDto> GetRiver(int id) 
        {
            // find river
            var riverToReturn = RiversDataStore.Current.River.FirstOrDefault(r=> r.Id== id);

            if (riverToReturn == null)
            {
                return NotFound();
            }

            return Ok(riverToReturn);

           
        }

        [HttpPost]

        public ActionResult<RiverDto> CreateRiver(
          RiverForCreatingDto riverToReturn)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var river = RiversDataStore.Current.River.FirstOrDefault(c => c.Name.ToUpper() == riverToReturn.Name.ToUpper());
            if (river != null)
            {
                return BadRequest("River with taht name alredy exists");
            }

            var maxRiverId = RiversDataStore.Current.River.SelectMany(c => RiversDataStore.Current.River).Max(p => p.Id);

            var finalRiver = new RiverDto()
            {
                Id = ++maxRiverId,
                Name = riverToReturn.Name,
                Description = riverToReturn.Description,
            };

            RiversDataStore.Current.River.Add(finalRiver);

            return Ok(finalRiver);
        }

        [HttpPut]

        public ActionResult UpdateCitiesInProvince(int riverId,
            CitiesInProvinceForUpdateDto changedRiver)
        {
            var river = RiversDataStore.Current.River.FirstOrDefault(c => c.Id == riverId);
            if (river == null)
            {
                return NotFound();
            }

            river.Name = changedRiver.Name;
            river.Description = changedRiver.Description;

            return NoContent();
        }


        [HttpDelete]

        public ActionResult DeleteCitiesInProvince(int riverId)
        {
            var river = RiversDataStore.Current.River.FirstOrDefault(c => c.Id == riverId);
            if (river == null)
            {
                return NotFound();
            }
            RiversDataStore.Current.River.Remove(river);
            //_mailService.Send("City in province deleted.",
            //    $"City in province {citiesInProvinciesFromStore.Name} with id {citiesInProvinciesFromStore.Id} was deleted.");
            return NoContent();
        }
    }
}
