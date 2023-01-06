using Cityinfo.API.Models;

namespace Cityinfo.API
{
    public class ProvinciesDataStore
    {
        public List<ProvinceDto>? Provincies { get; set; }

        //  public static ProvinciesDataStore Current { get; } = new ProvinciesDataStore();

        public ProvinciesDataStore()
        {

            Provincies = new List<ProvinceDto>()
            {
                new ProvinceDto()
                {
                    ID= 1,
                    Name= "Vojvodina",
                    Description = "Pokrajna na severu Srbije",
                    CitiesInProvince = new List<CitiesInProvinceDto>()
                    {
                        new CitiesInProvinceDto()
                        {
                            Id = 1,
                            Name = "Novi sad",
                            Description ="Najveci grad pokrajine vojvodine "
                        },
                         new CitiesInProvinceDto()
                        {
                            Id = 2,
                            Name = "Subotica",
                            Description ="Najseverniji grad pokrajine vojvodine "
                        },

                    }

                },
                new ProvinceDto()
            {
                ID = 2,
                Name= "Uza Srbija",
                Description = "Najveci deo Srbije",
                CitiesInProvince = new List<CitiesInProvinceDto>()
                    {
                        new CitiesInProvinceDto()
                        {
                            Id = 3,
                            Name = "Nis",
                            Description ="Najveci grad na jugu Srbije "
                        },
                         new CitiesInProvinceDto()
                        {
                            Id = 4,
                            Name = "Kraljevo",
                            Description ="Srce Sumadije"
                        },

                    }
            },
                new ProvinceDto()
            {
                ID = 3,
                Name= "Kosovo i Metrohija",
                Description = "Najveci grad u Vojvodini",
                CitiesInProvince = new List<CitiesInProvinceDto>()
                    {
                        new CitiesInProvinceDto()
                        {
                            Id = 5,
                            Name = "Pristina",
                            Description ="Glavni grad pokrajine"
                        },
                         new CitiesInProvinceDto()
                        {
                            Id = 6,
                            Name = "Kosovska Mitrovica",
                            Description ="Gradsko naselje na Kosovu"
                        },

                    }
            }
            };


        }
    }
}
