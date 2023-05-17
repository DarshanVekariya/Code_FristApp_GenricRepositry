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
    public class StateRepository : GenericRepository<StateTbl>, IStateRepository
    {
        public StateRepository(MyAppDbContext db) : base(db)
        {
        }
    }
}
