using ReservationSystem.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Data.Configuration
{
    class ReservationDetailConfig: EntityTypeConfiguration<ReservationDetail>
    {
        public ReservationDetailConfig()
        {
            ToTable("ReservationDetails");
            Property(c => c.ReservationId).IsRequired();
            Property(c => c.DateCreated).IsRequired();
            
        }
    }
}
