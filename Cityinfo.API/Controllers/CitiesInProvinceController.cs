using Cityinfo.API.Models;
using Cityinfo.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Cityinfo.API.Controllers
{
    [Route("api/province/{provinceID}/citiesinprovincies")]
    [Produces("application/json")]
    [ApiController]
    public class CitiesInProvinceController : ControllerBase
    {
        private readonly  ILogger<CitiesInProvinceController> _logger;
        private readonly  IMailService _mailService;
        private readonly ProvinciesDataStore _provinciesDataStore;

        public CitiesInProvinceController(ILogger<CitiesInProvinceController> logger, IMailService  mailService, ProvinciesDataStore provinciesDataStore) 
        { 
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mailService = mailService ?? throw new ArgumentNullException(nameof(mailService));
            _provinciesDataStore = provinciesDataStore ?? throw new ArgumentNullException(nameof(provinciesDataStore));
        }
    
        [HttpGet]
        public ActionResult<IEnumerable<CitiesInProvinceDto>> GetCitiesInProvince(int provinceId)
        {
            try
            {
               // throw new Exception("Exception sample");

                var province = _provinciesDataStore.Provincies.FirstOrDefault(c => c.Id == provinceId);

                if (province == null)
                {
                    _logger.LogInformation($"Province with id {provinceId} wasn't found");
                    return NotFound();
                }

                return Ok(province.CitiesInProvince);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Exception while getting cities in province for province with id {provinceId}.", ex);
                return StatusCode(500, "A problem happend while handling your request.");
            }
        }


        [HttpGet("{citiesinprovinciesid}", Name = "GetCitiesInProvince")]

        public ActionResult<CitiesInProvinceDto> GetCitiesInProvince(
            int provinceId, int citiesInProvinciesId)
        {
            var province =_provinciesDataStore.Provincies.FirstOrDefault(c => c.Id == provinceId);
            if (province == null)
            {
                return NotFound();
            }

            // find city in province
            var citiesInProvincies = province.CitiesInProvince.FirstOrDefault(c => c.Id == citiesInProvinciesId);
            if(citiesInProvincies == null) 
            {
                return NotFound();
            }
            return Ok(citiesInProvincies);

        }
        [HttpPost]

        public ActionResult<CitiesInProvinceDto> CreateCitiInProvince(
            int provinceId,
            CitiesInProvinceForCreatingDto citiesInProvincies)
        {
            if(!ModelState.IsValid) 
            {
                return BadRequest();
            }

            var province = _provinciesDataStore.Provincies.FirstOrDefault(c => c.Id == provinceId);
            if (province == null)
            {
                return NotFound();
            }

            var maxCitiesInProvincieId = _provinciesDataStore.Provincies.SelectMany( c => c.CitiesInProvince).Max(p => p.Id);

            var finalCitiesInProvincies = new CitiesInProvinceDto()
            {
                Id = ++maxCitiesInProvincieId,
                Name = citiesInProvincies.Name,
                Description = citiesInProvincies.Description,
            };

            province.CitiesInProvince.Add(finalCitiesInProvincies);

            return Ok(finalCitiesInProvincies);
        }

        [HttpPut("{citiesinprovinciesId} ")]

        public ActionResult UpdateCitiesInProvince(int provinceId, int citiesInProvinciesId, 
            CitiesInProvinceForUpdateDto citiesInProvincies)
        {
            var province = _provinciesDataStore.Provincies.FirstOrDefault(c => c.Id == provinceId);
            if (province == null)
            {
                return NotFound();
            }

            var citiesInProvinciesFromStore = province.CitiesInProvince.FirstOrDefault(c => c.Id == citiesInProvinciesId);
            if (citiesInProvinciesFromStore== null)
            {
                return NotFound();
            }

            citiesInProvinciesFromStore.Name = citiesInProvincies.Name;
            citiesInProvinciesFromStore.Description = citiesInProvincies.Description;

            return NoContent();
        }

        [HttpPatch("{citiesinprovinceid}")]

        public ActionResult PartiallyUpdateCitiesInProvince(
            int provinceId, int citiesInProvinciesId,
            JsonPatchDocument<CitiesInProvinceForUpdateDto> patchDocument)
        {
            var province = _provinciesDataStore.Provincies.FirstOrDefault(c => c.Id == provinceId);
            if (province == null)
            {
                return NotFound();
            }

            var citiesInProvinciesFromStore = province.CitiesInProvince.FirstOrDefault(c => c.Id == citiesInProvinciesId);
            if(citiesInProvinciesFromStore== null)
            {
                return NotFound();
            }

            var citiesInProvinciesToPatch =
                new CitiesInProvinceForUpdateDto()
                {
                    Name = citiesInProvinciesFromStore.Name,
                    Description = citiesInProvinciesFromStore.Description
                };

            patchDocument.ApplyTo(citiesInProvinciesToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!TryValidateModel(citiesInProvinciesToPatch))
            {
                return BadRequest(ModelState);
            }

            citiesInProvinciesFromStore.Name = citiesInProvinciesToPatch.Name;
            citiesInProvinciesFromStore.Description = citiesInProvinciesToPatch.Description;

                return NoContent();
        }

        [HttpDelete("{citiesinprovinciesid}")]

        public ActionResult DeleteCitiesInProvince( int provinceId, int citiesInProvinciesId)
        {
            var province = _provinciesDataStore.Provincies.FirstOrDefault(c => c.Id == provinceId);
            if (province == null)
            {
                return NotFound();
            }

            var citiesInProvinciesFromStore = province.CitiesInProvince.FirstOrDefault(c => c.Id == citiesInProvinciesId);
            if (citiesInProvinciesFromStore == null)
            {
                return NotFound();
            }

            province.CitiesInProvince.Remove(citiesInProvinciesFromStore);
            _mailService.Send("City in province deleted.",
                $"City in province {citiesInProvinciesFromStore.Name} with id {citiesInProvinciesFromStore.Id} was deleted.");
            return NoContent();
        }

    }
}
