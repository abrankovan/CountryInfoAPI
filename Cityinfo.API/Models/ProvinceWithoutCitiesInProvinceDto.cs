namespace Cityinfo.API.Models
{
    public class ProvinceWithoutCitiesInProvinceDto
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
