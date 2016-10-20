using ReservationSystem.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Data
{
    public class ReservationSeedData : DropCreateDatabaseIfModelChanges<ReservationEntities>
    {
        protected override void Seed(ReservationEntities context)
        {
           
            context.Commit();
        }
    }
}
