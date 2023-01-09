//using System.Security.Cryptography.X509Certificates;

namespace Cityinfo.API.Models
{
    public class ProvinceDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public int NumberOfCitiesInProvince
        {
            get
            {
                return CitiesInProvince.Count;
            }
        }
        public ICollection<CitiesInProvinceDto> CitiesInProvince { get; set; }
            = new List<CitiesInProvinceDto>();
    }
}
