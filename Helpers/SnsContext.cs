using Microsoft.EntityFrameworkCore;
using snscz_api.Models;

namespace snscz_api.Helpers 
{     
    public class SnsContext : DbContext     
  {         
        public SnsContext(DbContextOptions<SnsContext> options) : base(options)         
        {         
        }       
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Composition> Compositions { get; set; }
        public DbSet<Allergens> Allergens { get; set; }
    } 
}