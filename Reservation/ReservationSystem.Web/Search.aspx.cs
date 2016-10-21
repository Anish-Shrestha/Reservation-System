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

        [Inject]
        public IReservationDetailService _reservationDetailService { get; set; }

        [Inject]
        public IReservationService _reservationService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            _binddataObject();
            string errorMessage;
            var checkModelrvm = rvm.validate(out errorMessage);
            DataText.InnerText = errorMessage;
            if (checkModelrvm)
            {
                AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<ReservationViewModel, Reservation>());
                var insertedId = _reservationService.CreateReservation(AutoMapper.Mapper.Map<Reservation>(rvm));

                rvm.ReservationDetailList.ForEach(x => x.ReservationId = insertedId);
                rdvml = rvm.ReservationDetailList;

                AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<ReservationDetailViewModel, ReservationDetail>());
                _reservationDetailService.CreateReservationDetail(rdvml.Select(x => AutoMapper.Mapper.Map<ReservationDetail>(x)).ToList());
            }

        }

        public void _binddataObject()
        {
            SearchViewModel dataObject = new SearchViewModel();
            TryUpdateModel(dataObject, new FormValueProvider(ModelBindingExecutionContext));
            AutoMapperConfiguration.Configure();
            rvm = AutoMapper.Mapper.Map<ReservationViewModel>(dataObject);
            rdvml = bindDetailObject(dataObject);
            rvm.ReservationDetailList = rdvml;

        }

        public List<ReservationDetailViewModel> bindDetailObject(SearchViewModel dataObject)
        {
            List<ReservationDetailViewModel> lst = new List<ReservationDetailViewModel>();
            for (int i = 0; i < dataObject.Adult.Count(); i++)
            {
                lst.Add(new ReservationDetailViewModel(dataObject.Adult[i], dataObject.Children[i]));
            }
            return lst;
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


        }
    }
}
