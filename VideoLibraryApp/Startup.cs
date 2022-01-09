using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoLibraryApp.Startup))]
namespace VideoLibraryApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
