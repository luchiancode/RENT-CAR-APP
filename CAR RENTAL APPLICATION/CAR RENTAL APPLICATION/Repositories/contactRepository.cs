﻿using CAR_RENTAL_APPLICATION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAR_RENTAL_APPLICATION.Repositories
{
    public class contactRepository : RepositoryBase<contact>, IcontactRepository
    {
        public contactRepository(CarsContext contactContext)
            : base(contactContext)
        {
        }
    }
}