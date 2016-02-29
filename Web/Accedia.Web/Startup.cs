using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(Accedia.Web.Startup))]

namespace Accedia.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
