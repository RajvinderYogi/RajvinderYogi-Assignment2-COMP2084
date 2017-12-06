using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RajvinderYogi_Assignment2_COMP2084.Startup))]
namespace RajvinderYogi_Assignment2_COMP2084
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
