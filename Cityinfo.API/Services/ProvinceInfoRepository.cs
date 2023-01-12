using Cityinfo.API.DbContexts;
using Cityinfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace Cityinfo.API.Services
{
    public class ProvinceInfoRepository : IProvinceInfoRepository
    {
        private readonly ProvinceInfoContext _context;
        public ProvinceInfoRepository(ProvinceInfoContext context) 
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<CitiesInProvince>> GetCitiesInProvinceForProvinceAsync(int provinceId)
        {
            return await _context.CitiesInProvinces
                .Where(p => p.ProvinceId == provinceId)
                .ToListAsync();
        }

        public async Task<CitiesInProvince?> GetCitiesInProvinceForProvinceAsync(int provinceId, int citiesInProvinciesId)
        {
            return await _context.CitiesInProvinces
                .Where(p => p.ProvinceId == provinceId && p.Id == citiesInProvinciesId)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Province>> GetProvinceAsync()
        {
            return await _context.Provinces.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<Province?> GetProvinceAsync(int provinceId, bool icludeCitiesInProvince)
        {
            if (icludeCitiesInProvince)
            {
                return await _context.Provinces.Include(c => c.CitiesInProvince)
                    .Where(c => c.Id == provinceId).FirstOrDefaultAsync();
            }

            return await _context.Provinces
                .Where(c => c.Id == provinceId) .FirstOrDefaultAsync();
        }
        public async Task<bool> ProvinceExistsAsync(int provinceId)
        {
            return await _context.Provinces.AnyAsync(c => c.Id == provinceId);
        }
        public async Task AddCitiesInProvinceForProvinceAsync(int provinceId, CitiesInProvince citiesInProvince)
        {
            var province = await GetProvinceAsync(provinceId, false);
            if(province != null)
            {
                province.CitiesInProvince.Add(citiesInProvince);
            }
        }

        public void DeleteCitiesInProvince(CitiesInProvince citiesInProvince)
        {
            _context.CitiesInProvinces.Remove(citiesInProvince);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
