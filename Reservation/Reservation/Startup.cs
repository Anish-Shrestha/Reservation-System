using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Reservation.Startup))]
namespace Reservation
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
