using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(KendoCRUDService.Hubs.Startup1))]

namespace KendoCRUDService.Hubs
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.MapSignalR(new Microsoft.AspNet.SignalR.HubConfiguration()
            {
                EnableJSONP = true
            });
        }
    }
}
