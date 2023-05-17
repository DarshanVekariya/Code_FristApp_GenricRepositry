using DataAccess.Interface;
using Models;
using Models.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CountryRepository : GenericRepository<CountryTbl> ,  ICountryRepository 
    {
        public CountryRepository(MyAppDbContext db) : base(db)
        {
        }

        public void testmethod()
        {
            Console.WriteLine("This is testMethod from country repository");
        }
    }
}
