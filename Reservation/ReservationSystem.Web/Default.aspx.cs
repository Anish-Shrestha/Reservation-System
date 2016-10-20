using Ninject;
using Ninject.Web;
using ReservationSystem.Data;
using ReservationSystem.Model.Models;
using ReservationSystem.Service.Interface;
using ReservationSystem.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReservationSystem.Web
{
    public partial class _Default : PageBase
    {
        [Inject]
        public IReservationDetailService _reservationService { get; set; }
   
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var reserve = new ReservationDetail();
           
              reserve.Adults = 2233;
            reserve.Childrens = 3223;
            reserve.DateUpdated = DateTime.Now;
            reserve.DateCreated = DateTime.Now;
            reserve.Id = 223;

       //     using (var db = new ReservationEntities())
        //    {
                // Create and save a new Blog 
               
          //      db.ReservationDetails.Add(reserve);
         //       db.SaveChanges();

           // }
                _reservationService.CreateReservationDetail(reserve);
                 _reservationService.SaveReservationDetail();
        }
    }
}