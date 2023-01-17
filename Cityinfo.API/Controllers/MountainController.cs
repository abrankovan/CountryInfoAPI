using Cityinfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cityinfo.API.Controllers
{
    [ApiController]
    [Route("api/mountain")]
    [Produces("application/json")]
    public class MountainController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<MountainDto>> GetRiver()
        {
           
            return Ok(MountainsDataStore.Current.Mountain);
             
        }
        [HttpGet("{id}")]

        public ActionResult<MountainDto> GetMountain(int id) 
        {
            // find river
            var mountainToReturn = MountainsDataStore.Current.Mountain.FirstOrDefault(m=> m.Id== id);

            if (mountainToReturn == null)
            {
                return NotFound();
            }

            return Ok(mountainToReturn);

           
        }

        //[HttpPost]

        //public ActionResult<MountainDto> CreateMountain(
        //   int mountainID,
        //   MountainForCreatingDto mountain)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest();
        //    }

        //    var province = _provinciesDataStore.Provincies.FirstOrDefault(c => c.ID == provinceID);
        //    if (province == null)
        //    {
        //        return NotFound();
        //    }

        //    var maxCitiesInProvincieId = _provinciesDataStore.Provincies.SelectMany(c => c.CitiesInProvince).Max(p => p.Id);

        //    var finalCitiesInProvincies = new CitiesInProvinceDto()
        //    {
        //        Id = ++maxCitiesInProvincieId,
        //        Name = citiesInProvincies.Name,
        //        Description = citiesInProvincies.Description,
        //    };

        //    province.CitiesInProvince.Add(finalCitiesInProvincies);

        //    return Ok(finalCitiesInProvincies);
        //}
    }
}
