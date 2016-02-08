using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DailyStatusReport.Startup))]
namespace DailyStatusReport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
