using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oracle_sell_book.Startup))]
namespace Oracle_sell_book
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
