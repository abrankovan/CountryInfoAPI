using System.ComponentModel.DataAnnotations;

namespace Cityinfo.API.Models
{
    public class CitiesInProvinceForCreatingDto
    {
        [Required(ErrorMessage ="You should provide a name value")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(2000)]

        public string? Description { get; set; }
    }
}
