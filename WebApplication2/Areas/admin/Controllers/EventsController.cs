﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Areas.admin.Controllers
{
    public class EventsController : Controller
    {
        // GET: admin/Events
        public ActionResult Index()
        {
            return View();
        }
    }
}