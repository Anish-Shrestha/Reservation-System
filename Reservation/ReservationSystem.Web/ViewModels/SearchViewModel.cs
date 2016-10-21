using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationSystem.Web.ViewModels
{
    public class SearchViewModel
    {
        
        public string Location { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public int SelectRoomDropdown { get; set; }
        public List<int> Adult { get; set; }
        public List<int> Children { get; set; }
    }
}