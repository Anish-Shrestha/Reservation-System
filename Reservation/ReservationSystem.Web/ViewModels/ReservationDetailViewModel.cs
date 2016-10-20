using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationSystem.Web.ViewModels
{
    public class ReservationDetailViewModel
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public int Adults { get; set; }
        public int Childrens { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public ReservationDetailViewModel()
        {
            DateCreated = DateTime.Now;
        }
    }
}