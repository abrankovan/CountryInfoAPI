using Cityinfo.API.Entities;

namespace Cityinfo.API.Services
{
    public interface IProvinceInfoRepository
    {
        Task<IEnumerable<Province>> GetProvincesAsync();


    }
}
