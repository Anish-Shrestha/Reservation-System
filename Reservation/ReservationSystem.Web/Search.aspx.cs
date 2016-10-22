using log4net;
using Ninject;
using ReservationSystem.Model.Models;
using ReservationSystem.Service.Interface;
using ReservationSystem.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.ModelBinding;
using System.Web.UI.WebControls;

namespace ReservationSystem.Web
{
    public partial class Search : System.Web.UI.Page
    {

        private ReservationViewModel rvm;
        private List<ReservationDetailViewModel> rdvml;
        private static string successMessage;
        private static readonly ILog log = LogManager.GetLogger("ReservationSystem");

        [Inject]
        public IReservationDetailService _reservationDetailService { get; set; }

        [Inject]
        public IReservationService _reservationService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                BindDropDownList();  // Bind dropdown list values

                // Display success message after successful reservation.
                if (!string.IsNullOrEmpty(successMessage) && SuccessMessageLabl != null)
                {
                    SuccessMessageLabl.Text = successMessage;
                    successMessage = null;
                }
                else
                    SuccessMessageLabl.Text = string.Empty;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
        }

        /// <summary>
        ///  Method to create reservation and reservation detail.
        /// </summary>
        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage;
                SuccessMessageLabl.Text = string.Empty;
                _binddataObject(); // Bind data object to ViewModel

                var checkModelrvm = rvm.validate(out errorMessage); // Validate data in ViewModel

                if (checkModelrvm) // If Model state is valid
                {
                    // Create reservation information
                    var insertedId = _reservationService.CreateReservation(AutoMapper.Mapper.Map<Reservation>(rvm));
                    rvm.ReservationDetailList.ForEach(x => x.ReservationId = insertedId);
                    rdvml = rvm.ReservationDetailList;
                    // Create reservation detail information
                    _reservationDetailService.CreateReservationDetail(rdvml.Select(x => AutoMapper.Mapper.Map<ReservationDetail>(x)).ToList());
                    successMessage = string.Format(ReservationResource.SuccessReservation, rvm.Location);
                    Response.Redirect("Search.aspx", false);

                }
                else // If Model state is not valid
                {
                    DataText.InnerText = errorMessage;  // Display error message

                    // Retain form information after post back
                    formDataMaintain();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message); // logging exception information using Log4Net
                DataText.InnerText = string.Format(ReservationResource.FatalError); // Display error message
            }

        }

        #region Private Methods 

        /// <summary>
        /// Retain form information after post back
        /// </summary>
        private void formDataMaintain()
        {
            try
            {
                var newDate = new DateTime();
                if (rvm.CheckIn != newDate)
                    Checkin.Text = rvm.CheckIn.ToString("MM/dd/yyyy");
                if (rvm.CheckOut != newDate)
                    Checkout.Text = rvm.CheckOut.ToString("MM/dd/yyyy");
                SelectRoomDropdown.SelectedValue = rvm.Rooms.ToString();
               
                SelectRoomDropdown.Items.FindByValue(rvm.Rooms.ToString()).Selected = true;
                //Adult.Items.FindByValue(rvm.ReservationDetailList.First().Adult.ToString()).Selected = true;
                //Children.Items.FindByValue(rvm.ReservationDetailList.First().Children.ToString()).Selected = true;
                Location.Text = rvm.Location;
            }
            catch { throw; }
        }

        /// <summary>
        /// Bind data object to ViewModel
        /// </summary>
        private List<ReservationDetailViewModel> bindDetailObject(SearchViewModel dataObject)
        {
            try
            {
                List<ReservationDetailViewModel> lst = new List<ReservationDetailViewModel>();
                for (int i = 0; i < dataObject.Adult.Count(); i++)
                {
                    adultList.Text += dataObject.Adult[i] + ",";
                    childrenList.Text += dataObject.Children[i] + ",";
                    lst.Add(new ReservationDetailViewModel(dataObject.Adult[i], dataObject.Children[i]));
                }
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Bind data object to ViewModel
        /// </summary>
        private void _binddataObject()
        {
            try
            {
                SearchViewModel dataObject = new SearchViewModel();
                TryUpdateModel(dataObject, new FormValueProvider(ModelBindingExecutionContext));
                rvm = AutoMapper.Mapper.Map<ReservationViewModel>(dataObject);
                rdvml = bindDetailObject(dataObject);
                rvm.ReservationDetailList = rdvml;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Vaue of dropdown list present in Search.aspx is bind using this method.
        /// </summary>
        private void BindDropDownList()
        {
            try
            {
                SelectRoomDropdown.Items.Clear();
                Adult.Items.Clear();
                Children.Items.Clear();
                for (int i = 1; i < 10; i++)
                {
                    var lst = new ListItem(i.ToString(), i.ToString());
                    SelectRoomDropdown.Items.Add(lst);
                    Adult.Items.Add(lst);
                    Children.Items.Add(lst);
                }
            }
            catch
            {
                throw;
            }
        }

        #endregion

    }
}
