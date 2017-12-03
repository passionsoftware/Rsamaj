using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Areas.admin.Controllers
{
    public class BaseController : Controller
    {
       
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
                // here I will check users exists in database.
                // if yes , 
                isAuthenticated = true;
            }
            return isAuthenticated;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //filterContext.HttpContext.Response.Redirect("/admin/login/?returningURL=" +
            //    filterContext.HttpContext.Server.UrlEncode(filterContext.HttpContext.Request.Url.ToString()));

            filterContext.HttpContext.Response.Redirect("/admin/login/?User=Invalid");

        }

    }

}