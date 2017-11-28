using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Areas.admin.Controllers
{
    public class RathoreDetailsController : Controller
    {
        // GET: admin/RathoreDetail
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddRathoreDetail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRathoreDetail(int i)
        {
            return View();
        }

        public ActionResult EditRathoreDetail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditRathoreDetail(int i)
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteRathoreDetail(int i)
        {
            return View();
        }
    }
}