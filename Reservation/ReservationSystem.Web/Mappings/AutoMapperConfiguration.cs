using AutoMapper;
using ReservationSystem.Model.Models;
using ReservationSystem.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationSystem.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Reservation, ReservationViewModel>();
                cfg.CreateMap<ReservationDetail, ReservationDetailViewModel>();
            });

            Mapper.Initialize(cfg => {
                cfg.CreateMap<ReservationViewModel, Reservation>();
                cfg.CreateMap<ReservationDetailViewModel, ReservationDetail>();
            });

        }
    }
}