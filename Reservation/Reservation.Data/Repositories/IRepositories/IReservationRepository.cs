using ReservationSystem.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservationSystem.Model.Models;
namespace ReservationSystem.Data.Repositories.IRepositories
{
    public interface IReservationRepository : IRepository<Reservation>
    {
      //  Reservation GetReservationByLocation(string location);
    }
}
