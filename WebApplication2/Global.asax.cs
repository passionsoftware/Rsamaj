using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }


        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            RouteData routeData = new RouteData();

            routeData.Values.Add("controller", "Error");

            Guid ErrorId = Guid.NewGuid();
            routeData.Values.Add("ErrorId", ErrorId);
            Response.Clear();


            if (ex is HttpException)
            {
                if (((HttpException)ex).GetHttpCode() == 404)
                {
                    routeData.Values.Add("action", "PageNotFound");
                }
                else if (((HttpException)ex).GetHttpCode() == 401)
                {
                    routeData.Values.Add("action", "UnAuthorized");
                }
                else
                {
                    routeData.Values.Add("ErrorValue", ex);
                    routeData.Values.Add("action", "Index");
                }
            }
            else if (ex is Exception)
            {
                routeData.Values.Add("ErrorValue", ex);
                routeData.Values.Add("action", "Index");
            }

            // LogHelper.ErrorLog(ErrorId.ToString(),ex);

            //Clear error in server
            Server.ClearError();

            Response.TrySkipIisCustomErrors = true;

            // Call the target controller and pass the route data
            IController errorController = new WebApplication2.Controllers.ErrorController();
            errorController.Execute(new RequestContext(new HttpContextWrapper(Context),routeData));
        }
    }
}
