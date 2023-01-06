using Cityinfo.API.Models;

namespace Cityinfo.API
{
    public class MountainsDataStore
    {
        public List<MountainDto>? Mountain { get; set; }

        public static MountainsDataStore Current { get; } = new MountainsDataStore()
        {
            Mountain = new List<MountainDto>()
            {
                new MountainDto()
                {
                    Id= 1,
                    Name= "Kopaonik",
                    Description = "...",
                },
                new MountainDto()
                {
                Id = 2,
                Name= "Zlatibor",
                Description = "...",
                
                },
                new MountainDto()
                {
                Id = 3,
                Name= "Tara",
                Description = "...",
                }
            }
            


        };
    }
}
