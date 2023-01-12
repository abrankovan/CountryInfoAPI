using Cityinfo.API.Models;
using Cityinfo.API.Services;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace Cityinfo.API.Controllers
{
    [ApiController]
    [Route("api/province")]
    [Produces("application/json")]
    public class ProvinciesController : ControllerBase
    {
        private readonly IProvinceInfoRepository _provinceInfoRepository;
        private readonly IMapper _mapper;

        public ProvinciesController(IProvinceInfoRepository provinceInfoRepository,
            IMapper mapper)
        {
            _provinceInfoRepository= provinceInfoRepository ?? throw new ArgumentNullException(nameof(provinceInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProvinceWithoutCitiesInProvinceDto>>> GetCities()
        {
            var provinceEntities = await _provinceInfoRepository.GetProvinceAsync();
            return Ok(_mapper.Map<IEnumerable<ProvinceWithoutCitiesInProvinceDto>>(provinceEntities));
           // return Ok(_provinciesDataStore.Provincies);
             
        }
        [HttpGet("{id}")]

        public async Task<IActionResult> GetCity(
            int id, bool includeCitiesInProvince = false) 
        {
            var province = await _provinceInfoRepository.GetProvinceAsync(id, includeCitiesInProvince);
            if(province == null)
            {
                return NotFound();
            }
            if (includeCitiesInProvince)
            {
                return Ok(_mapper.Map<ProvinceDto>(province));
            }
            return Ok(_mapper.Map<ProvinceWithoutCitiesInProvinceDto>(province));
           
        }
    }
}
