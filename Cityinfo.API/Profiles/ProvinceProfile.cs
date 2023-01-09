using AutoMapper;

namespace Cityinfo.API.Profiles
{
    public class ProvinceProfile : Profile
    {
        public ProvinceProfile()
        {
            CreateMap<Entities.Province, Models.ProvinceDto>();
        }
    }
}
