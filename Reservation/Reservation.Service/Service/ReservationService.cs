using ReservationSystem.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservationSystem.Model.Models;
using ReservationSystem.Data.Infrastructure;
using ReservationSystem.Data.Repositories.IRepositories;

namespace ReservationSystem.Service
{
    public class ReservationService : IReservationService
    {
        
        private readonly IReservationRepository _reservationRepository;
     

        public ReservationService(IReservationRepository reservationRepository)
        {
            this._reservationRepository = reservationRepository;
        
        }
        public int CreateReservation(Reservation reservation)
        {
            _reservationRepository.Add(reservation);
            SaveReservation();
            return reservation.Id;
        
        }

        public void SaveReservation()
        {
            _reservationRepository.Commit();
        }
    }
}
