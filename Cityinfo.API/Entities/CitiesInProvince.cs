using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cityinfo.API.Entities
{
    public class CitiesInProvince
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }

        [MaxLength(2000)]

        public string Description { get; set; }


        [ForeignKey("ProvinceId")]
        public Province ? Province { get; set; }
        public int ProvinceId { get; set; }


        public CitiesInProvince(string name) 
        {
            Name = name;
        }
    }
}
