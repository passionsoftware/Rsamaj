using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Areas.admin.Controllers
{
    [RathoreSamajAuth]
    public class NewsController : BaseController
    {
        // GET: admin/News
        public ActionResult Index()
        {
            return View();
        }
    }
}