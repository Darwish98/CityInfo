using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!; //about this -> 6.4, min 2:50 in video

        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;


        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {

        }

        /*override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("connectionstring");
            base.OnConfiguring(optionsBuilder);
        }*/
    }
}
