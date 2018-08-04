using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PasswordAfterMailConfirmation.Startup))]
namespace PasswordAfterMailConfirmation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
