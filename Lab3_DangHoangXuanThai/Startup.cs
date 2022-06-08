using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_DangHoangXuanThai.Startup))]
namespace Lab3_DangHoangXuanThai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
