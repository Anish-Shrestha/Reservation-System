using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationSystem.Web.ViewModels
{
    public class ReservationViewModel
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Rooms { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public List<ReservationDetailViewModel> ReservationDetailList { get; set; }

        public ReservationViewModel()
        {
            DateCreated = DateTime.Now;
        }
    }
}