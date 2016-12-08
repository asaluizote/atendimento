using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASA.Atendimentos.Startup))]
namespace ASA.Atendimentos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
