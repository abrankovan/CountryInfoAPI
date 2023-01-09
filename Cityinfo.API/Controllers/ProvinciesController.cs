using AutoMapper;
using Cityinfo.API.Models;
using Cityinfo.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cityinfo.API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/province")]
    public class ProvinciesController : ControllerBase
    {
        //private readonly ProvinciesDataStore _provinciesDataStore;

        private readonly IProvinceInfoRepository _provinceInfoRepository;
        private readonly IMapper _mapper;


        public ProvinciesController(/*ProvinciesDataStore provinciesDataStore,*/ IProvinceInfoRepository provinceInfoRepository, IMapper mapper)
        {
            //_provinciesDataStore = provinciesDataStore;
            _provinceInfoRepository = provinceInfoRepository ??
                throw new ArgumentNullException(nameof(provinceInfoRepository));
            _mapper = mapper ??
               throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProvinceDto>>> GetProvinces()
        {
            var provinceEntities = await _provinceInfoRepository.GetProvincesAsync();
            //return Ok(_provinciesDataStore.Provincies);
            return Ok(_mapper.Map<IEnumerable<ProvinceDto>>(provinceEntities));

        }
        //[HttpGet("{id}")]

        //public ActionResult<ProvinceDto> GetCity(int id) 
        //{
        //    // find city
        //    var cityToReturn = _provinciesDataStore.Provincies.FirstOrDefault(c=> c.ID== id);

        //    if (cityToReturn == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(cityToReturn);


        //}
    }
}
