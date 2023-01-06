using Cityinfo.API.Models;

namespace Cityinfo.API
{
    public class RiversDataStore
    {
        public List<RiverDto>? River { get; set; }

        public static RiversDataStore Current { get; } = new RiversDataStore()
        {
            River = new List<RiverDto>()
            {
                new RiverDto()
                {
                    Id= 1,
                    Name= "Dunav",
                    Description = "...",
                },
                new RiverDto()
                {
                Id = 2,
                Name= "Sava",
                Description = "...",
                
                },
                new RiverDto()
                {
                Id = 3,
                Name= "Morava",
                Description = "...",
                }
            }
            


        };
    }
}
