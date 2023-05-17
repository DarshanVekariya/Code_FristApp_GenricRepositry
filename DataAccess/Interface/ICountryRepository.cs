﻿using Models.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface ICountryRepository : IGenericRepository<CountryTbl>
    {
        void testmethod();
    }
}