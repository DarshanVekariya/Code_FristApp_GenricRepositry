using Microsoft.EntityFrameworkCore;
using Models.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) :base(options) 
        {
            
        }
        public DbSet<CountryTbl>countryTbls { get; set; }      

        public DbSet<StateTbl> stateTbls { get; set; }

        public DbSet<CityTbl> cityTbls { get; set; }    
        
    }
}
