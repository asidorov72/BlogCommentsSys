using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogCommentsSys.Web.Startup))]
namespace BlogCommentsSys.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}