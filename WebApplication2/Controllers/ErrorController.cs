using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            Response.ContentType = "text/html";
            try
            {
                Exception exception = this.RouteData.Values["ErrorValue"] != null ? (Exception)this.RouteData.Values["ErrorValue"] : null;
                string errorId = this.RouteData.Values["ErrorId"].ToString();
                string message = exception != null ? exception.Message.ToString() : "Undefined Error";
                string stackTrace = exception.StackTrace.ToString();

                ViewBag.ErrorId = errorId;
                ViewBag.Message = message;
                ViewBag.StackTrace = stackTrace;
            }
            catch (Exception ex)
            {
                Guid ErrorId = Guid.NewGuid();
                ViewBag.ErrorId = ErrorId;
                ViewBag.Message = ex.Message.ToString();
                ViewBag.StackTrace = ex.StackTrace.ToString();
                // LogHelper.ErrorLog(ErrorId.ToString(),ex);
            }
            return View();
        }

        public ActionResult PageNotFound()
        {
            Response.ContentType = "text/html";
            return View();
        }

        public ActionResult UnAuthorized()
        {
            Response.ContentType = "text/html";
            return View();
        }
    }
}