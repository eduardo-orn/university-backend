using Owin;
using University.BL.Data;


namespace University
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext(UniversityContext.create);
        }
    }
}
