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
    }
}
