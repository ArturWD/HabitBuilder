using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HabitBuilder.Startup))]
namespace HabitBuilder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
