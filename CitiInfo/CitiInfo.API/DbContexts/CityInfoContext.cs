﻿using CitiInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CitiInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext(DbContextOptions<CityInfoContext> options) 
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; } = null!; // null forgiving operator
        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;
    }
}
