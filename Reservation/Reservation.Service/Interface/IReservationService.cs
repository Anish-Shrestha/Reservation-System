using ReservationSystem.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Service.Interface
{
    public interface IReservationService
    {
        int CreateReservation(Reservation reservation);
        void SaveReservation();
    }
}
