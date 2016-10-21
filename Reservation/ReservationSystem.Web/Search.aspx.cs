using log4net;
using Ninject;
using ReservationSystem.Model.Models;
using ReservationSystem.Service.Interface;
using ReservationSystem.Web.Mappings;
using ReservationSystem.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReservationSystem.Web
{
    public partial class Search : System.Web.UI.Page
    {
        private ReservationViewModel rvm;
        private List<ReservationDetailViewModel> rdvml;
        private static readonly ILog log = LogManager.GetLogger("ReservationSystem");

        [Inject]
        public IReservationDetailService _reservationDetailService { get; set; }

        [Inject]
        public IReservationService _reservationService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                SuccessMessageLabel.Text = string.Empty;
                _binddataObject();
                string errorMessage;
                var checkModelrvm = rvm.validate(out errorMessage);
                DataText.InnerText = errorMessage;
                if (checkModelrvm)
                {
                    var insertedId = _reservationService.CreateReservation(AutoMapper.Mapper.Map<Reservation>(rvm));
                    rvm.ReservationDetailList.ForEach(x => x.ReservationId = insertedId);
                    rdvml = rvm.ReservationDetailList;
                    _reservationDetailService.CreateReservationDetail(rdvml.Select(x => AutoMapper.Mapper.Map<ReservationDetail>(x)).ToList());
                    SuccessMessageLabel.Text = string.Format(ReservationResource.SuccessReservation, rvm.Location);

                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                DataText.InnerText = string.Format(ReservationResource.FatalError);
            }

        }

        public void _binddataObject()
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

        public List<ReservationDetailViewModel> bindDetailObject(SearchViewModel dataObject)
        {
            try
            {
                List<ReservationDetailViewModel> lst = new List<ReservationDetailViewModel>();
                for (int i = 0; i < dataObject.Adult.Count(); i++)
                {
                    lst.Add(new ReservationDetailViewModel(dataObject.Adult[i], dataObject.Children[i]));
                }
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
