using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleEFCodeFirst.Startup))]
namespace SampleEFCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
