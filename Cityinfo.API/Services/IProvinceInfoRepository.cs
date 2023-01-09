using Cityinfo.API.Entities;

namespace Cityinfo.API.Services
{
    public interface IProvinceInfoRepository
    {
        Task<IEnumerable<Province>> GetProvincesAsync();

        Task<Province?> GetProvinceAsync(int provinceId, bool includeCities);
    }
}
