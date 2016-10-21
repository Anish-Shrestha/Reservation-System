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
using System.Web.ModelBinding;

namespace ReservationSystem.Web
{
    public partial class _Default : PageBase
    {
        [Inject]
        public IReservationDetailService _reservationDetailService { get; set; }

        [Inject]
        public IReservationService _reservationService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            var location = Location.Text;
            var checkIn = Checkin.Text;
            var checkout = Checkout.Text;
            var room = SelectRoomDropdown.Text;
            _binddataObject();

        }

        public void _binddataObject()
        {
            SearchViewModel dataObject = new SearchViewModel();

          

            if (TryUpdateModel(dataObject, new FormValueProvider(ModelBindingExecutionContext)))
            {
                DataText.InnerText = String.Format("Location: {0},    Checkin: {1},   Checkout: {2}, Adult:{3},Children:{4}",
                  dataObject.Location, dataObject.Checkin, dataObject.Checkout, dataObject.Adult, dataObject.Children);
            }
       
        }

        // not in use
        public void addReservationForm_InsertItem()
        {
            var item = new ReservationViewModel();

            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
               
            }
        }

     
        // for test
        protected void Button1_Click(object sender, EventArgs e)
        {
            var reserve = new ReservationDetail();
           
              reserve.Adult = 2233;
            reserve.Children = 3223;
            reserve.DateUpdated = DateTime.Now;
            reserve.DateCreated = DateTime.Now;
            reserve.Id = 223;

          
            _reservationDetailService.CreateReservationDetail(reserve);
            _reservationDetailService.SaveReservationDetail();
        }
    }
}