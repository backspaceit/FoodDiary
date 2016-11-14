using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodDiary.Startup))]
namespace FoodDiary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
