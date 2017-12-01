using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDienThoaiDiDong.Startup))]
namespace WebDienThoaiDiDong
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
