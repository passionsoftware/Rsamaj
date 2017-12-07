using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RS.DataModel;

namespace WebApplication2.Areas.admin.Controllers
{
    public class BaseController : Controller
    {
        public int LoginUserID
        {
            get { return (Session["LoginSuccesFull"] != null) ?  ((LoginModel)Session["LoginSuccesFull"]).RathoreDetailId : 0 ; }
        }

    }

    

    public class RathoreSamajAuth : AuthorizeAttribute
    {

        public RathoreSamajAuth()
            : base()
        {

        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool isAuthenticated = false;
          
            if (httpContext.Session["LoginSuccesFull"] != null)
            {
                List<string> _allowRoles = Roles.Split(',').ToList();
                int? userRoles = ((LoginModel)httpContext.Session["LoginSuccesFull"]).Role;
                if (Roles == null || Roles == string.Empty)
                {
                    isAuthenticated = true;
                }
                else
                {
                    if (!_allowRoles.Contains(Convert.ToString(userRoles)))
                    {
                        isAuthenticated = false;
                    }
                    else
                    {
                        isAuthenticated = true;
                    }
                }
                // here I will check users exists in database.
                // if yes , 
              
            }
            return isAuthenticated;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //filterContext.HttpContext.Response.Redirect("/admin/login/?returningURL=" +
            //    filterContext.HttpContext.Server.UrlEncode(filterContext.HttpContext.Request.Url.ToString())); 
            //  filterContext.HttpContext.Response.Redirect("/admin/login/?User=Invalid");
            filterContext.Result = new HttpUnauthorizedResult();

            //Or
            //Check.Require(filterContext != null);

            //if (service.HasPermission(requiredPermission))
            //    return;

            //filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Home" }, { "action", "NoPermission" } })

        }

    }

}