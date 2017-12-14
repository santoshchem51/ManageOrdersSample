using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SCM.ManageOrders.Web.Startup))]
namespace SCM.ManageOrders.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
