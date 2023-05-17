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
    public class CityRepository : GenericRepository<CityTbl>, ICityRepository
    {
        public CityRepository(MyAppDbContext db) : base(db)
        {
        }
    }
}
