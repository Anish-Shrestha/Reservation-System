using ReservationSystem.Data.Repositories;
using ReservationSystem.Data.Repositories.IRepositories;
using ReservationSystem.Service;
using ReservationSystem.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationSystem.Web.App_Start
{
    public class BindingWebModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
                              
        }
    }
}