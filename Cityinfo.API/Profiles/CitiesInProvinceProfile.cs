using AutoMapper;

namespace Cityinfo.API.Profiles
{
    public class CitiesInProvinceProfile : Profile
    {
        public CitiesInProvinceProfile()
        {
            CreateMap<Entities.CitiesInProvince, Models.CitiesInProvinceDto>();
            CreateMap<Models.CitiesInProvinceForCreatingDto, Entities.CitiesInProvince>();
            CreateMap<Models.CitiesInProvinceForUpdateDto, Entities.CitiesInProvince>();    
        }
    } 
}
