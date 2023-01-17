using Cityinfo.API.Entities;

namespace Cityinfo.API.Services
{
    public interface IProvinceInfoRepository
    {
        Task<IEnumerable<Province>> GetProvinceAsync();
        Task<Province?> GetProvinceAsync(int provinceID, bool includeCitiesInProvince);
        Task<bool> ProvinceExistsAsync(int provinceID);
        Task<IEnumerable<CitiesInProvince>> GetCitiesInProvinceForProvinceAsync(int provinceID);
        Task<CitiesInProvince?> GetCitiesInProvinceForProvinceAsync(int provinceID, 
            int citiesInProvinciesId);
        Task AddCitiesInProvinceForProvinceAsync(int provinceID, CitiesInProvince citiesInProvince);
        void DeleteCitiesInProvince(CitiesInProvince citiesInProvince);
        Task<bool> SaveChangesAsync();
    }
}
