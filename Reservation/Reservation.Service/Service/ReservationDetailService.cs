using ReservationSystem.Data.Repositories.IRepositories;
using ReservationSystem.Model.Models;
using ReservationSystem.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ReservationSystem.Service
{
    public class ReservationDetailService : IReservationDetailService
    {
        private readonly IReservationDetailRepository _reservationDetailRepository;


        public ReservationDetailService(IReservationDetailRepository reservationDetailRepository)
        {
            this._reservationDetailRepository = reservationDetailRepository;
        }

        public void CreateReservationDetail(IEnumerable<ReservationDetail> rdml)
        {
            foreach (var item in rdml.ToList())
            {
                _reservationDetailRepository.Add(item);
            }
            _reservationDetailRepository.Commit();
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
