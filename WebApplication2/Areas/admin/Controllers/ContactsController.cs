using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Areas.admin.Controllers
{
    public class ContactsController : Controller
    {
        // GET: admin/Contacts
        public ActionResult Index()
        {
            return View();
        }
    }
}