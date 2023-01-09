using Cityinfo.API.Entities;
using Cityinfo.API.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Cityinfo.API.Services
{
    public class ProvinceInfoRepository : IProvinceInfoRepository
    {
        private readonly ProvinceInfoContext _context;

        public ProvinceInfoRepository(ProvinceInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Province>> GetProvincesAsync()
        {
            return await _context.Provinces.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<Province?> GetProvinceAsync(int provinceId, bool includeCities)
        {
            if (includeCities)
            {
                return await _context.Provinces.Include(c => c.CitiesInProvince)
                    .Where(c => c.Id == provinceId).FirstOrDefaultAsync();
            }

            return await _context.Provinces
                  .Where(c => c.Id == provinceId).FirstOrDefaultAsync();
        }
    }
}
