using Cityinfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cityinfo.API.Controllers
{
    [ApiController]
    [Route("api/province")]
    public class ProvinciesController : ControllerBase
    {
        private readonly ProvinciesDataStore _provinciesDataStore;

        public ProvinciesController(ProvinciesDataStore provinciesDataStore) 
        {
            _provinciesDataStore = provinciesDataStore;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProvinceDto>> GetCities()
        {
           
            return Ok(_provinciesDataStore.Provincies);
             
        }
        [HttpGet("{id}")]

        public ActionResult<ProvinceDto> GetCity(int id) 
        {
            // find city
            var cityToReturn = _provinciesDataStore.Provincies.FirstOrDefault(c=> c.ID== id);

            if (cityToReturn == null)
            {
                return NotFound();
            }

            return Ok(cityToReturn);

           
        }
    }
}
