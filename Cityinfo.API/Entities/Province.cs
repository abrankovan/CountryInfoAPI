using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cityinfo.API.Entities
{
    public class Province
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]

        public string Name { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        public ICollection<CitiesInProvince> CitiesInProvince { get; set; } 
            = new List<CitiesInProvince>();

        public Province(string name) 
        {
            Name = name;
        }
    }
}
