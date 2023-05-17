using DataAccess.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UnitOfWorkRepository : IUnitOfWork
    {
        private readonly MyAppDbContext _db;
        public UnitOfWorkRepository(MyAppDbContext db)
        {
            _db = db;
            CountryRepository = new CountryRepository(_db);
            StateRepository = new StateRepository(_db);
            CityRepository = new CityRepository(_db);
        }
        public ICountryRepository CountryRepository { get; private set; }

        public IStateRepository StateRepository { get; private set; }

        public ICityRepository CityRepository { get; private set; }

        public int Completed()
        {
            return _db.SaveChanges();
        }
    }
}
