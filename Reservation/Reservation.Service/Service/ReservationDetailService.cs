using ReservationSystem.Data.Infrastructure;
using ReservationSystem.Data.Repositories;
using ReservationSystem.Data.Repositories.IRepositories;
using ReservationSystem.Model.Models;
using ReservationSystem.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Service
{
    public class ReservationDetailService : IReservationDetailService
    {
        private readonly IReservationDetailRepository _reservationDetailRepository;
      

        public ReservationDetailService(IReservationDetailRepository reservationDetailRepository)
        {
            this._reservationDetailRepository = reservationDetailRepository;
        }
        public void CreateReservationDetail(ReservationDetail reservationDetail)
        {
            _reservationDetailRepository.Add(reservationDetail);
        }

        public void SaveReservationDetail()
        {
            _reservationDetailRepository.Commit();
        }
    }
}
