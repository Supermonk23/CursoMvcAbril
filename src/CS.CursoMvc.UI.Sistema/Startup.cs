using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS.CursoMvc.UI.Sistema.Startup))]
namespace CS.CursoMvc.UI.Sistema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
