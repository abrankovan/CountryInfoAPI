﻿namespace Cityinfo.API.Models
{
    public class ProvinceWithoutCitiesDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
