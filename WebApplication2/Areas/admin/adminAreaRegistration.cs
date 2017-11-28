using System.Web.Mvc;

namespace WebApplication2.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {

                            context.MapRoute(
                    name: "Error",
                    url: "admin",
                    defaults: new { controller = "Login", action = "index" }
                    );


                            context.MapRoute(
                     "Admin_default",
                     "Admin/{controller}/{action}/{id}",
                     new { action = "Index", id = UrlParameter.Optional },
                     new[] { "WebApplication2.Areas.Admin.Controllers" }
                        );
        }
    }
}