﻿using ReservationSystem.Data.Infrastructure;
using ReservationSystem.Data.Repositories.IRepositories;
using ReservationSystem.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Data.Repositories
{
    public class ReservationDetailRepository : RepositoryBase<ReservationDetail>, IReservationDetailRepository
    {
       
        public ReservationDetailRepository() 
            : base() { }

    }

    
}
