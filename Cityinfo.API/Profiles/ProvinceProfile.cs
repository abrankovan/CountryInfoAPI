using AutoMapper;

namespace Cityinfo.API.Profiles
{
    public class ProvinceProfile : Profile
    {
        public ProvinceProfile()
        {
            CreateMap<Entities.Province, Models.ProvinceWithoutCitiesDto>();
            CreateMap<Entities.Province, Models.ProvinceDto>();
            CreateMap<Entities.CitiesInProvince, Models.CitiesInProvinceDto>();
        }
    }
}
