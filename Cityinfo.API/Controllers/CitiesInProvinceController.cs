using AutoMapper;
using Cityinfo.API.Models;
using Cityinfo.API.Services;
using Microsoft.AspNetCore.Authorization;
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
        private readonly ILogger<CitiesInProvinceController> _logger;
        private readonly IMailService _mailService;
        private readonly IProvinceInfoRepository _provinceInfoRepository;
        private readonly ProvinciesDataStore _provinciesDataStore;
        private readonly IMapper _mapper;

        public CitiesInProvinceController(ILogger<CitiesInProvinceController> logger,
            IMailService mailService,
            IProvinceInfoRepository provinceInfoRepository,
            IMapper mapper)
        {
            if (provinceInfoRepository is null)
            {
                throw new ArgumentNullException(nameof(provinceInfoRepository));
            }

            _logger = logger ??
                throw new ArgumentNullException(nameof(logger));
            _mailService = mailService ??
                throw new ArgumentNullException(nameof(mailService));
            _provinceInfoRepository = provinceInfoRepository ??
                throw new ArgumentNullException(nameof(provinceInfoRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }   

            [HttpGet]

            public async Task<ActionResult<IEnumerable<CitiesInProvinceDto>>> GetCitiesInProvince(
                int provinceID)
            {
                if (!await _provinceInfoRepository.ProvinceExistsAsync(provinceID))
                {
                    _logger.LogInformation(
                        $"Province with id {provinceID} wasn't found when accesing points of interest.");
                    return NotFound();
                }
                var citiesInProvinceForProvince = await _provinceInfoRepository
                        .GetCitiesInProvinceForProvinceAsync(provinceID);
                return Ok(_mapper.Map<IEnumerable<CitiesInProvinceDto>>(citiesInProvinceForProvince));
            }


            [HttpGet("{citiesinprovinciesid}", Name = "GetCitiesInProvince")]

            public async Task<ActionResult<CitiesInProvinceDto>> GetCitiesInProvince(
                int provinceID, int citiesInProvinciesId)
            {
                if (!await _provinceInfoRepository.ProvinceExistsAsync(provinceID))
                {
                    return NotFound();
                }

                // find city in province
                var citiesInProvincies = await _provinceInfoRepository
                    .GetCitiesInProvinceForProvinceAsync(provinceID, citiesInProvinciesId);

                if (citiesInProvincies == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<CitiesInProvinceDto>(citiesInProvincies));

            }

        [HttpPost]
		[Authorize]
		public async Task<ActionResult<CitiesInProvinceDto>> CreateCitiInProvince(
                int provinceID,
                CitiesInProvinceForCreatingDto citiesInProvincies)
            {
                if (!await _provinceInfoRepository.ProvinceExistsAsync(provinceID))
                {
                    return NotFound();
                }

                var finalCitiesInProvincies = _mapper.Map<Entities.CitiesInProvince>(citiesInProvincies);

                await _provinceInfoRepository.AddCitiesInProvinceForProvinceAsync(
                    provinceID, finalCitiesInProvincies);

                await _provinceInfoRepository.SaveChangesAsync();

                var createdCitiesInProvinceToReturn =
                    _mapper.Map<Models.CitiesInProvinceDto>(finalCitiesInProvincies);


                return CreatedAtRoute("GetCitiesInProvince",
                new
                {
                    provinceID = provinceID,
                    citiesInProvinciesId = createdCitiesInProvinceToReturn.Id
                },
                finalCitiesInProvincies);
            }

            [HttpPut("{citiesinprovinciesId} ")]

            public async Task<ActionResult> UpdateCitiesInProvince(int provinceID, int citiesInProvinciesId,
                CitiesInProvinceForUpdateDto citiesInProvincies)
            {
                if(!await _provinceInfoRepository.ProvinceExistsAsync(provinceID))
                {
                    return NotFound();
                }
                var citiesInProvinciesEntity = await _provinceInfoRepository
                    .GetCitiesInProvinceForProvinceAsync(provinceID, citiesInProvinciesId);

                if (citiesInProvinciesEntity == null)
                {
                    return NotFound();
                }

                _mapper.Map(citiesInProvincies, citiesInProvinciesEntity);
                
                await _provinceInfoRepository.SaveChangesAsync();

                return NoContent();
            }

            //[HttpPatch("{citiesinprovinceid}")]

            //public ActionResult PartiallyUpdateCitiesInProvince(
            //    int provinceID, int citiesInProvinciesId,
            //    JsonPatchDocument<CitiesInProvinceForUpdateDto> patchDocument)
            //{
            //    var province = _provinciesDataStore.Provincies.FirstOrDefault(c => c.ID == provinceID);
            //    if (province == null)
            //    {
            //        return NotFound();
            //    }

            //    var citiesInProvinciesFromStore = province.CitiesInProvince.FirstOrDefault(c => c.Id == citiesInProvinciesId);
            //    if (citiesInProvinciesFromStore == null)
            //    {
            //        return NotFound();
            //    }

            //    var citiesInProvinciesToPatch =
            //        new CitiesInProvinceForUpdateDto()
            //        {
            //            Name = citiesInProvinciesFromStore.Name,
            //            Description = citiesInProvinciesFromStore.Description
            //        };

            //    patchDocument.ApplyTo(citiesInProvinciesToPatch, ModelState);

            //    if (!ModelState.IsValid)
            //    {
            //        return BadRequest(ModelState);
            //    }
            //    if (!TryValidateModel(citiesInProvinciesToPatch))
            //    {
            //        return BadRequest(ModelState);
            //    }

            //    citiesInProvinciesFromStore.Name = citiesInProvinciesToPatch.Name;
            //    citiesInProvinciesFromStore.Description = citiesInProvinciesToPatch.Description;

            //    return NoContent();
            //}

            [HttpDelete("{citiesinprovinciesid}")]

            public async Task<ActionResult> DeleteCitiesInProvince(
                int provinceID, int citiesInProvinciesId)
            {
                if (!await _provinceInfoRepository.ProvinceExistsAsync(provinceID))
                {
                    return NotFound();
                }

                var citiesInProvinceEntity = await _provinceInfoRepository
                    .GetCitiesInProvinceForProvinceAsync(provinceID, citiesInProvinciesId);
                if (citiesInProvinceEntity == null)
                {
                    return NotFound();
                }

                _provinceInfoRepository.DeleteCitiesInProvince(citiesInProvinceEntity);


               
                _mailService.Send("City in province deleted.",
                    $"City in province {citiesInProvinceEntity.Name} with id {citiesInProvinceEntity.Id} was deleted.");
                return NoContent();
            }

    }
} 

