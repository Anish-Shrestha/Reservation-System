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
        public void CreateReservation(Reservation reservation)
        {
            _reservationRepository.Add(reservation);
           
        
        }

        public void SaveReservation()
        {
            _reservationRepository.Commit();
        }
    }
}
