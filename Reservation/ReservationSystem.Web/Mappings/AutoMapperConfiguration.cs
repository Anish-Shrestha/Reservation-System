﻿using AutoMapper;
using ReservationSystem.Model.Models;
using ReservationSystem.Web.ViewModels;

namespace ReservationSystem.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<SearchViewModel, ReservationViewModel>()
                  .ForMember(dest => dest.Location, opts => opts.MapFrom(src => src.Location))
                  .ForMember(dest => dest.CheckIn, opts => opts.MapFrom(src => src.Checkin))
                  .ForMember(dest => dest.CheckOut, opts => opts.MapFrom(src => src.Checkout))
                   .ForMember(dest => dest.Rooms, opts => opts.MapFrom(src => src.SelectRoomDropdown));
                cfg.CreateMap<ReservationViewModel, Reservation>();
                cfg.CreateMap<ReservationDetailViewModel, ReservationDetail>();
            });
        }
    }
}