
using log4net;
using ReservationSystem.Data;
using ReservationSystem.Web.Mappings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ReservationSystem.Web
{
    public class Global : HttpApplication
    {
        private static readonly ILog log = LogManager.GetLogger("ReservationSystem");

        void Application_Start(object sender, EventArgs e)
        {
            // Init database
            System.Data.Entity.Database.SetInitializer(new ReservationSeedData());
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfiguration.Configure();
            log4net.Config.XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/Web.config")));



        }

        protected void Application_Error(object sender, EventArgs e) {

            Exception ex = Server.GetLastError();
            log.Debug("____________________________________");
            log.Error(ex);
            log.Debug("____________________________________");
        }
    }
}